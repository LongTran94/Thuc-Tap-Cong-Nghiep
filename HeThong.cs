﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_tập_lớn
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }
        Ketnoi tv = new Ketnoi();
        private void Form1_Load(object sender,EventArgs e)
        {
           
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia fm = new QuanLyDocGia();
            fm.ShowDialog();
        }

        private void btnQuanLyThe_Click(object sender, EventArgs e)
        {
            QuanlyThe fm = new QuanlyThe();
            fm.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Search fm = new Search();
            fm.ShowDialog();
        }

        private void btnTheodoimuontrasach_Click(object sender, EventArgs e)
        {
            Theodoimuontrasach fm = new Theodoimuontrasach();
            fm.ShowDialog();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            Thongke fm = new Thongke();
            fm.ShowDialog();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            QuanlySach fm = new QuanlySach();
            fm.ShowDialog();
        }


        
    }
}
