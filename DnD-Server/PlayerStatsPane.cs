﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class PlayerStatsPane : Form {
        public PlayerStatsPane() {
            InitializeComponent();
        }

        private void skillsbtn_Click(object sender, EventArgs e) {
            Form f = new PlayerSkillsPane();
            f.Show();
        }
    }
}
