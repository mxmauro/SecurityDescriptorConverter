using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;

namespace SecurityDescriptorConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBinSd2StrSd_Click(object sender, EventArgs e)
        {
            string s;
            byte[] aSrc;
            RawSecurityDescriptor sd;

            s = txtSource.Text.Trim();
            if (s.Length == 0)
            {
                MessageBox.Show("Please fill the source binary SDDL", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            aSrc = ByteArrayFromString(s);
            if (aSrc == null)
            {
                MessageBox.Show("Invalid binary SDDL", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            try
            {
                sd = new RawSecurityDescriptor(aSrc, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid binary SDDL", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            txtDest.Text = sd.GetSddlForm(AccessControlSections.All);
        }

        private void btnStrSd2BinSd_Click(object sender, EventArgs e)
        {
            RawSecurityDescriptor sd;
            string s;
            byte[] aDest;

            s = txtSource.Text.Trim();
            if (s.Length == 0)
            {
                MessageBox.Show("Please fill the source SDDL string", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            try
            {
                sd = new RawSecurityDescriptor(s);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid SDDL string", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            aDest = new byte[sd.BinaryLength];
            sd.GetBinaryForm(aDest, 0);
            txtDest.Text = BitConverter.ToString(aDest).Replace("-", " ");
        }

        private void btnBinSid2StrSid_Click(object sender, EventArgs e)
        {
            string s;
            byte[] aSrc;
            SecurityIdentifier sid;

            s = txtSource.Text.Trim();
            if (s.Length == 0)
            {
                MessageBox.Show("Please fill the binary SDDL", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            aSrc = ByteArrayFromString(s);
            if (aSrc == null)
            {
                MessageBox.Show("Invalid binary SDDL", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            try
            {
                sid = new SecurityIdentifier(aSrc, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid binary SDDL", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            txtDest.Text = sid.ToString();
        }

        private void btnStrSid2BinSid_Click(object sender, EventArgs e)
        {
            SecurityIdentifier sid;
            string s;
            byte[] aDest;

            s = txtSource.Text.Trim();
            if (s.Length == 0)
            {
                MessageBox.Show("Please fill the source SDDL string", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            try
            {
                sid = new SecurityIdentifier(s);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid SDDL string", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
                return;
            }
            aDest = new byte[sid.BinaryLength];
            sid.GetBinaryForm(aDest, 0);
            txtDest.Text = BitConverter.ToString(aDest).Replace("-", " ");
        }

        private byte[] ByteArrayFromString(string s)
        {
            byte[] aData;
            int i, charsCount;

            for (i = charsCount = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '\t' || s[i] == '\r' || s[i] == '\n' || s[i] == ',' || s[i] == '\\')
                    continue;
                if (HexCharToDigit(s[i]) < 0)
                    return null;
                if (i+1 >= s.Length)
                    return null;
                if (HexCharToDigit(s[i+1]) < 0)
                    return null;
                i++;
                charsCount++;
            }
            aData = new byte[charsCount];
            for (i = charsCount = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '\t' || s[i] == '\r' || s[i] == '\n' || s[i] == ',' || s[i] == '\\')
                    continue;
                aData[charsCount] = (byte)(HexCharToDigit(s[i]) * 16 + HexCharToDigit(s[i + 1]));
                i++;
                charsCount++;
            }
            return aData;
        }

        private int HexCharToDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return (int)ch - 48;
            if (ch >= 'A' && ch <= 'F')
                return (int)ch - 55;
            if (ch >= 'a' && ch <= 'f')
                return (int)ch - 87;
            return -1;
        }
    }
}
