using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersonelRegisterWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            groupRegister.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new personelregistercontext())
            {
                // get all user information
                var users = db.peoples.ToList();

                var dataGridViewUsers = users.Select(u => new
                {
                    ID = u.Id,
                    UserName = u.User_Name,
                    Email = u.Email,
                    Enabled = u.Enabled ? "true" : "false"
                }).ToList();

                // upload to dgw
                dgwShowData.DataSource = dataGridViewUsers;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new personelregistercontext())
            {
                //user information was retrieved from the database
                
                string username = txtUserName.Text;
                bool isEnabled = checkEnabled.Checked;
                string email = txtEmail.Text;
                string phonenumber = txtPhone.Text;
                string displayname = txtDisplay.Text;
                string userroles = comboUserRoles.Text;

                // user information added to database

                People newUser = new People
                {
                    User_Name = username,
                    Enabled = isEnabled,
                    Email = email,
                    Phone = phonenumber,
                    Display_Name = displayname,
                    User_Roles = userroles,


                };

                db.peoples.Add(newUser);
                db.SaveChanges();
            }
            MessageBox.Show("User successfully registered.");
        }

        private void checkHide_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new personelregistercontext())
            {
                if (checkHide.Checked)
                {
                    // If CheckBox is checked, load only Enabled users into DataGridView
                    var users = db.peoples.Where(p => p.Enabled).ToList();
                    dgwShowData.DataSource = users;
                }
                else
                {
                    // If CheckBox is unchecked, load all users into DataGridView
                    var users = db.peoples.ToList();
                    dgwShowData.DataSource = users;
                }
            }
        }
    }
}
