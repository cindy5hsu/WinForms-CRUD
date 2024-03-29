﻿using Project_Store.infra.Extensions;
using Project_Store.models.Service;
using Project_Store.models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Store
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            string account = accountTextBox.Text;
            string password = passwordTextBox.Text;
            string name = nameTextBox.Text;

            // 將它們繫結到ViewModel
            UserVM model = new UserVM
            {
                Account = account,
                Password = password,
                Name = name,
            };

            // 針對ViewModel進行欄位驗證
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Account", accountTextBox},
                {"Password", passwordTextBox},
                {"Name", nameTextBox},
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;


            // 如果通過驗證,就新增記錄
            try
            {
                new UserService().Create(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗, 原因: " + ex.Message);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
