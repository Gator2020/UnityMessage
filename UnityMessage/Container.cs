﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityMessage
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }
        public Panel PanelHandle { get; set; }
        public IntPtr XPanel;
        public IntPtr YPanel;


        private void Container_Load(object sender, EventArgs e)
        {
            PanelHandle = panel6;
         
                XPanel = panel3.Handle;
              
                    YPanel = panel4.Handle;
                
            }


        }
    }

