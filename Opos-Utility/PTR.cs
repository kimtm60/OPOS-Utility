using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Opos_Utility
{
    public partial class PTR : Form
    {
        public const int PTR_S_RECEIPT = 2;
        public const int PTR_CP_FULLCUT = 100;

        string[] rkey_ptr;
        string[] rkey_ptr_sub;

        int returnCode_open = 100;
        int returnCode_claim = 100;
        int returnCode_release = 100;
        int returnCode_close = 100;

        //OPOS Error Constant 
        public const int OPOSERR = 100;
        public const int OPOSERREXT = 200;
        public const int OPOS_SUCCESS = 0;
        public const int OPOS_E_CLOSED = 101;
        public const int OPOS_E_CLAIMED = 102;
        public const int OPOS_E_NOTCLAIMED = 103;
        public const int OPOS_E_NOSERVICE = 104;
        public const int OPOS_E_DISABLED = 105;
        public const int OPOS_E_ILLEGAL = 106;
        public const int OPOS_E_NOHARDWARE = 107;
        public const int OPOS_E_OFFLINE = 108;
        public const int OPOS_E_NOEXIST = 109;
        public const int OPOS_E_EXISTS = 110;
        public const int OPOS_E_FAILURE = 111;
        public const int OPOS_E_TIMEOUT = 112;
        public const int OPOS_E_BUSY = 113;
        public const int OPOS_E_EXTENDED = 114;

        String text = "계산원: 전산실 TEL:02 - 2081 - 0500\n" +
                 "POS:5105 - 000038     2016 / 10 / 30(일) 11:35\n" +
                 "일    자: 2016-10-30(일요일)\n" +
                 "시    간: (오전) 11시 35분\n" +
                 "거래번호: 000038 " +
                 "개설사원: 전산실      (1111111)\n\n" +
                 " .............SIGN ON......OK.............\n\n\n\n\n\n";

        public PTR()
        {
            InitializeComponent();
            axOPOSPOSPrinter1.CreateControl();

            rkey_ptr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetValueNames();
            rkey_ptr_sub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetSubKeyNames();

            ptr_text.Text = text;

            device_name.Items.AddRange(rkey_ptr);
            device_name.Items.AddRange(rkey_ptr_sub);
            device_name.SelectedIndex = 0;

            simpleModeCheck.Checked = true;
        }

        private void detail_btn_Click(object sender, EventArgs e)
        {
            if (sender.Equals(dOpen_btn))
            {
                returnCode_open = axOPOSPOSPrinter1.Open(device_name.Text);
                open_returnCode.Text = getReturnStatus(returnCode_open);
                dClaim_btn.Enabled = true;
            }

            if (sender.Equals(dClaim_btn))
            {
                returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);
                claim_returnCode.Text = getReturnStatus(returnCode_open);
                dEnable_btn.Enabled = true;
                dDisable_btn.Enabled = true;
                dRelease_btn.Enabled = true;
                dClose_btn.Enabled = true;
            }

            if (sender.Equals(dEnable_btn))
            {
                axOPOSPOSPrinter1.DeviceEnabled = true;

            }

            if (sender.Equals(dDisable_btn))
                axOPOSPOSPrinter1.DeviceEnabled = false;

            if (sender.Equals(dRelease_btn))
            {
                returnCode_release = axOPOSPOSPrinter1.ReleaseDevice();
                release_returnCode.Text = getReturnStatus(returnCode_release);
            }
            if (sender.Equals(dClose_btn))
            {
                returnCode_close = axOPOSPOSPrinter1.Close();
                close_returnCode.Text = getReturnStatus(returnCode_close);
                dClaim_btn.Enabled = false;
                dEnable_btn.Enabled = false;
                dDisable_btn.Enabled = false;
                dRelease_btn.Enabled = false;
                dClose_btn.Enabled = false;
                init_returnCode();
                sClose_btn.Enabled = false;
            }
        }

        private void sOpen_btn_Click(object sender, EventArgs e)
        {
            returnCode_open = axOPOSPOSPrinter1.Open(device_name.Text);
            open_returnCode.Text = getReturnStatus(returnCode_open);
            returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);
            claim_returnCode.Text = getReturnStatus(returnCode_open);
            axOPOSPOSPrinter1.DeviceEnabled = true;
            sClose_btn.Enabled = true;

        }

        private void sClose_btn_Click(object sender, EventArgs e)
        {
            axOPOSPOSPrinter1.DeviceEnabled = false;
            returnCode_release = axOPOSPOSPrinter1.ReleaseDevice();
            release_returnCode.Text = getReturnStatus(returnCode_release);
            returnCode_close = axOPOSPOSPrinter1.Close();
            close_returnCode.Text = getReturnStatus(returnCode_close);
            init_returnCode();
            sClose_btn.Enabled = false;
        }

        private String getReturnStatus(int returnCode)
        {
            String returnStatus = "";

            switch (returnCode)
            {
                case OPOSERR: returnStatus = "OPOSERR"; break;
                case OPOS_SUCCESS: returnStatus = "OPOS_SUCCESS"; break;
                case OPOS_E_CLOSED: returnStatus = "OPOS_E_CLOSED"; break;
                case OPOS_E_CLAIMED: returnStatus = "OPOS_E_CLAIMED"; break;
                case OPOS_E_NOTCLAIMED: returnStatus = "OPOS_E_NOTCLAIMED"; break;
                case OPOS_E_NOSERVICE: returnStatus = "OPOS_E_NOSERVICE"; break;
                case OPOS_E_DISABLED: returnStatus = "OPOS_E_DISABLED"; break;
                case OPOS_E_NOHARDWARE: returnStatus = "OPOS_E_NOHARDWARE"; break;
                case OPOS_E_OFFLINE: returnStatus = "OPOS_E_OFFLINE"; break;
                case OPOS_E_ILLEGAL: returnStatus = "OPOS_E_ILLEGAL"; break;
                case OPOS_E_NOEXIST: returnStatus = "OPOS_E_NOEXIST"; break;
                case OPOS_E_EXISTS: returnStatus = "OPOS_E_EXISTS"; break;
                case OPOS_E_FAILURE: returnStatus = "OPOS_E_FAILURE"; break;
                case OPOS_E_TIMEOUT: returnStatus = "OPOS_E_TIMEOUT"; break;
                case OPOS_E_BUSY: returnStatus = "OPOS_E_BUSY"; break;
                case OPOS_E_EXTENDED: returnStatus = "OPOS_E_EXTENDED"; break;
                default: returnStatus = "ERROR"; break;
            }

            return returnStatus;
        }

        private void default_btn_Click(object sender, EventArgs e)
        {
            ptr_text.Text = text;
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                String fileText;
                fileText = sr.ReadToEnd();
                ptr_text.Text=fileText;
            }
            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ptr_text.Clear();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            int ret = axOPOSPOSPrinter1.PrintNormal(PTR_S_RECEIPT,
                       ptr_text.Text);
            axOPOSPOSPrinter1.CutPaper(PTR_CP_FULLCUT);
        }

        private void simpleModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(simpleModeCheck.Checked == true)
            {
                dOpen_btn.Text = "O";
                dClaim_btn.Text = "C";
                dEnable_btn.Text = "E";
                dDisable_btn.Text = "D";
                dRelease_btn.Text = "R";
                dClose_btn.Text = "C";

                simpleModeGroup.Visible = true;
                
                if (returnCode_open != 0)
                {
                    sClose_btn.Enabled = false;
                }
                else
                {
                    sClose_btn.Enabled = true;
                }
            }
            else
            {
                dOpen_btn.Text = "Open";
                dClaim_btn.Text = "Claim";
                dEnable_btn.Text = "Enable";
                dDisable_btn.Text = "Disable";
                dRelease_btn.Text = "Release";
                dClose_btn.Text = "Close";
                

                if (returnCode_open == 0)
                {
                    dClaim_btn.Enabled = true;
                    if (returnCode_claim == 0)
                    {
                        dEnable_btn.Enabled = true;
                        dDisable_btn.Enabled = true;
                        dRelease_btn.Enabled = true;
                        dClose_btn.Enabled = true;
                    }
                    else
                    {
                        dEnable_btn.Enabled = false;
                        dDisable_btn.Enabled = false;
                        dRelease_btn.Enabled = false;
                        dClose_btn.Enabled = false;
                    }

                }
                else
                {
                    dClaim_btn.Enabled = false;
                    dEnable_btn.Enabled = false;
                    dDisable_btn.Enabled = false;
                    dRelease_btn.Enabled = false;
                    dClose_btn.Enabled = false;
                }

                detailModeGroup.Visible = true;
                simpleModeGroup.Visible = false;

            }
        }

        private void clearReturnCode_btn_Click(object sender, EventArgs e)
        {
            open_returnCode.Text = "Return Code";
            claim_returnCode.Text = "Return Code";
            release_returnCode.Text = "Return Code";
            close_returnCode.Text = "Return Code";
        }
        private void init_returnCode()
        {
            returnCode_open = 100;
            returnCode_claim = 100;
            returnCode_release = 100;
            returnCode_close = 100;
        }
    }
}
