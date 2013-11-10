﻿namespace DnD_Client
{
    partial class ClientUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.msgEntryBox = new System.Windows.Forms.TextBox();
            this.adventureLogBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monsterList = new System.Windows.Forms.TreeView();
            this.currentPlayerList = new System.Windows.Forms.TreeView();
            this.dndlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(433, 338);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(50, 61);
            this.sendMsgButton.TabIndex = 14;
            this.sendMsgButton.Text = "Send";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adventure Log";
            // 
            // msgEntryBox
            // 
            this.msgEntryBox.Location = new System.Drawing.Point(138, 338);
            this.msgEntryBox.Multiline = true;
            this.msgEntryBox.Name = "msgEntryBox";
            this.msgEntryBox.Size = new System.Drawing.Size(289, 61);
            this.msgEntryBox.TabIndex = 11;
            // 
            // adventureLogBox
            // 
            this.adventureLogBox.BackColor = System.Drawing.SystemColors.Window;
            this.adventureLogBox.Location = new System.Drawing.Point(138, 76);
            this.adventureLogBox.Multiline = true;
            this.adventureLogBox.Name = "adventureLogBox";
            this.adventureLogBox.ReadOnly = true;
            this.adventureLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adventureLogBox.Size = new System.Drawing.Size(345, 256);
            this.adventureLogBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Monsters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Connected Players:";
            // 
            // monsterList
            // 
            this.monsterList.Location = new System.Drawing.Point(7, 247);
            this.monsterList.Name = "monsterList";
            this.monsterList.Size = new System.Drawing.Size(121, 152);
            this.monsterList.TabIndex = 7;
            // 
            // currentPlayerList
            // 
            this.currentPlayerList.Location = new System.Drawing.Point(7, 75);
            this.currentPlayerList.Name = "currentPlayerList";
            this.currentPlayerList.Size = new System.Drawing.Size(121, 153);
            this.currentPlayerList.TabIndex = 8;
            // 
            // dndlabel
            // 
            this.dndlabel.AutoSize = true;
            this.dndlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dndlabel.Location = new System.Drawing.Point(192, 7);
            this.dndlabel.Name = "dndlabel";
            this.dndlabel.Size = new System.Drawing.Size(123, 53);
            this.dndlabel.TabIndex = 6;
            this.dndlabel.Text = "D&&D";
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 406);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgEntryBox);
            this.Controls.Add(this.adventureLogBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monsterList);
            this.Controls.Add(this.currentPlayerList);
            this.Controls.Add(this.dndlabel);
            this.Name = "ClientUI";
            this.Text = "DnD - Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox msgEntryBox;
        private System.Windows.Forms.TextBox adventureLogBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView monsterList;
        private System.Windows.Forms.TreeView currentPlayerList;
        private System.Windows.Forms.Label dndlabel;
    }
}

