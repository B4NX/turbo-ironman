﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD {
    public partial class DungeonMap : Form {

        protected MainUI ParentUI;

        public DnDTile[,] Grid;
        public const int GRIDSIZE = 20;

        public Pen pen = new Pen(Color.Black);
        protected DungeonMap() {
            InitializeComponent();
        }
        public DungeonMap(MainUI parent) {
            InitializeComponent();
            this.ParentUI = parent;
            this.Shown += (object sender, EventArgs e) => {
                this.Left = ParentUI.Left + ParentUI.Width;
                this.Top = ParentUI.Top + (ParentUI.Height - this.Height) / 2;
            };

            this.Grid = new DnDTile[100, 100];

            mapPanel.Width = GRIDSIZE * 100;
            mapPanel.Height = GRIDSIZE * 100;
            mapPanel.Paint += MakeGridSquares;
            mapPanel.Paint += DrawObjects;

            this.ClientSize = new Size(361, 361);

            //Scroll to the middle of the map
            using (Control c = new Control() { Parent = container, Height = 1, Top = container.ClientSize.Height / 2 + (GRIDSIZE * 50), Width = 1, Left = container.ClientSize.Width / 2 + (GRIDSIZE * 50) }) {
                container.ScrollControlIntoView(c);
            }
            mapPanel.Left = -(GRIDSIZE * 50);
            mapPanel.Top = -(GRIDSIZE * 50);
        }

        public void Update(DnDTile[,] grid) {
            this.Grid = grid;
        }
        public void Update(int x, int y, DnDTile obj) {
            this.Grid[x, y] = obj;
        }

        private void MakeGridSquares(object sender, PaintEventArgs e) {
            for (int x = 0; x < Grid.GetLength(0) * GRIDSIZE; x += GRIDSIZE) {
                if (x >= e.ClipRectangle.Left && x <= e.ClipRectangle.Right) {
                    e.Graphics.DrawLine(pen, new Point(x, e.ClipRectangle.Top), new Point(x, e.ClipRectangle.Bottom));
                }
            } 
            for (int y = 0; y < Grid.GetLength(1) * GRIDSIZE; y += GRIDSIZE) {
                if (y >= e.ClipRectangle.Top && y <= e.ClipRectangle.Bottom) {
                    e.Graphics.DrawLine(pen, new Point(e.ClipRectangle.Left, y), new Point(e.ClipRectangle.Right, y));
                }
            }
        }

        private void DrawObjects(object sender, PaintEventArgs e) {
            for (int x = (e.ClipRectangle.Left / GRIDSIZE); x < (e.ClipRectangle.Right / GRIDSIZE); ++x) {
                for (int y = (e.ClipRectangle.Top / GRIDSIZE); y < (e.ClipRectangle.Bottom / GRIDSIZE); ++y) {
                    if (Grid[x, y] != null) {
                        Grid[x, y].Draw(e.Graphics);
                    }
                }
            }
        }

        public Point PointToGrid(Point p) {
            return new Point(p.X / GRIDSIZE, p.Y / GRIDSIZE);
        }

        protected virtual void mapPanel_MouseClick(object sender, MouseEventArgs e) {

        }
    }
}
