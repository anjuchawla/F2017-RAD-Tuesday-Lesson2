using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuesdayPromotions_Lesson2
{
    public partial class frmPromtions : Form
    {
        public frmPromtions()
        {
            InitializeComponent();
        }

        private void frmPromtions_Load(object sender, EventArgs e)
        {
            StartUp();
        }
        /// <summary>
        /// Operations when form is loaded/cleared
        /// </summary>
        private void StartUp()
        {
            //disable input controls
            grpDepartment.Enabled = false;
            chkImageVisible.Enabled = false;
            picDepartment.Visible = false;
            //disable output controls
            rtxWelcome.Visible = false;
            txtPromotion.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //check name and member id is provided
            if(txtName.Text.Equals(String.Empty))
            {
                MessageBox.Show( "Please provide your name", "Name Missing");
                txtName.Focus();
            }
            else
            if(mtxMemberId.Text.Length != 5)
            {
                MessageBox.Show("Please provide your 5 digited member ID", "Member ID error");
                mtxMemberId.Focus();

            }
            else
            {
                // make output visible and display a welcome message
                rtxWelcome.Visible = true;
                txtPromotion.Visible = true;
                rtxWelcome.Text = "Welcome " + txtName.Text + Environment.NewLine +
                        "Your member id " + mtxMemberId.Text + " is verified.";
                // disable sign in input and button
                grpInput.Enabled = false;
                btnSignIn.Enabled = false;

                //enable other inputs for user
                grpDepartment.Enabled = true;
                chkImageVisible.Enabled = true;
               

            }
        }
        /// <summary>
        /// Handles when the clothing department is chosen
        /// </summary>
        /// <param name="sender">Clothing radio button</param>
        /// <param name="e">The event arguments</param>
        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            txtPromotion.Text = "30% off clearance items";
            picDepartment.Image = Properties.Resources.clothing;
        }

        private void chkImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            picDepartment.Visible = chkImageVisible.Checked;
        }
        /// <summary>
        /// Bring the form to its start default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all previous inputs; enable inputs
            txtName.Text = string.Empty;
            mtxMemberId.Text = "";
            chkImageVisible.Checked = false;
            rdoJuiceBar.Checked = true;
            rdoJuiceBar.Checked = false;
            grpInput.Enabled = true;
            btnSignIn.Enabled = true;
            txtName.Focus();

            //clear the outputs
            rtxWelcome.Text = string.Empty;
            txtPromotion.Text = string.Empty;

            //default start state
            StartUp();




        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
                    }
    }
}
