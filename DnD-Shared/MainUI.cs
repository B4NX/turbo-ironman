﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DnD {
    public partial class MainUI : Form {

        protected string adventureLog;
        protected DungeonMap DungeonMap;

        public MainUI() {
            InitializeComponent();
        }

        protected virtual void sendMsgButton_Click(object sender, EventArgs e) {
            //log the message, then clear the textbox.
            string msg = msgEntryBox.Text;
            logAdventure(msg, "World");
            msgEntryBox.Text = "";
        }

        public virtual void logAdventure(string msg, string sender) {

        }

        private void msgEntryBox_KeyPress(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (Control.ModifierKeys != Keys.Control) {                    
                    sendMsgButton.PerformClick();
                    e.SuppressKeyPress = true;
                }
            }
        }

        public void AddMonster(Monster m) {
            MonsterTreeNode n = new MonsterTreeNode(m);
            monsterList.Nodes.Add(n);
            monsterList.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                ((MonsterTreeNode)e.Node).Monster.GetPane(this).Show();
            };
        }

        public void AddPlayer(Player p) {
            PlayerTreeNode q = new PlayerTreeNode(p);
            playerList.Nodes.Add(q);
            playerList.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                ((PlayerTreeNode)e.Node).Player.GetPane(this).Show();
            };
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
        }
    }
}
