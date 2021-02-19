﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Monitoring
{
    public partial class gsDongCo3 : UserControl
    {
        private static gsDongCo3 _instance;
        public static gsDongCo3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsDongCo3();
                return _instance;
            }
        }
        public gsDongCo3()
        {
            InitializeComponent();
        }
    }
}