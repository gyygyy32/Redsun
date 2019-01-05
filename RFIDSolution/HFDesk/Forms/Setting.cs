using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace HFDesk
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btnCVSSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*csv*)|*.csv*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径   
                txtCSVPath.Text = file;
                new Jsonhelp().writejson("CSVFilePath", file, AppDomain.CurrentDomain.BaseDirectory + "config.json");
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            txtCSVPath.Text = new Jsonhelp().readjson("CSVFilePath", AppDomain.CurrentDomain.BaseDirectory + "config.json");
        }
    }
}
