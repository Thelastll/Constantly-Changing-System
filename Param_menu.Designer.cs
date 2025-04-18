namespace ConstantlyChangingSystem
{
    partial class Param_menu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.del_g_param = new System.Windows.Forms.Button();
            this.add_g_param = new System.Windows.Forms.Button();
            this.g_param_list = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.g_param_list, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 723);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список параметров для всех объектов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.add_g_param, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.del_g_param, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 678);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 45);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // del_g_param
            // 
            this.del_g_param.BackColor = System.Drawing.Color.Honeydew;
            this.del_g_param.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_g_param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.del_g_param.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.del_g_param.FlatAppearance.BorderSize = 2;
            this.del_g_param.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.del_g_param.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.del_g_param.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_g_param.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_g_param.Location = new System.Drawing.Point(15, 5);
            this.del_g_param.Margin = new System.Windows.Forms.Padding(15, 5, 7, 5);
            this.del_g_param.Name = "del_g_param";
            this.del_g_param.Size = new System.Drawing.Size(219, 35);
            this.del_g_param.TabIndex = 6;
            this.del_g_param.Text = "x";
            this.del_g_param.UseVisualStyleBackColor = false;
            // 
            // add_g_param
            // 
            this.add_g_param.BackColor = System.Drawing.Color.Honeydew;
            this.add_g_param.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_g_param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_g_param.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_g_param.FlatAppearance.BorderSize = 2;
            this.add_g_param.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.add_g_param.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.add_g_param.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_g_param.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_g_param.Location = new System.Drawing.Point(248, 5);
            this.add_g_param.Margin = new System.Windows.Forms.Padding(7, 5, 15, 5);
            this.add_g_param.Name = "add_g_param";
            this.add_g_param.Size = new System.Drawing.Size(219, 35);
            this.add_g_param.TabIndex = 8;
            this.add_g_param.Text = "+";
            this.add_g_param.UseVisualStyleBackColor = false;
            // 
            // g_param_list
            // 
            this.g_param_list.BackColor = System.Drawing.Color.Honeydew;
            this.g_param_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g_param_list.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.g_param_list.FormattingEnabled = true;
            this.g_param_list.ItemHeight = 16;
            this.g_param_list.Location = new System.Drawing.Point(15, 21);
            this.g_param_list.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.g_param_list.Name = "g_param_list";
            this.g_param_list.Size = new System.Drawing.Size(452, 657);
            this.g_param_list.TabIndex = 2;
            // 
            // Param_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(482, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Param_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "param_menu";
            this.Load += new System.EventHandler(this.Param_menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button del_g_param;
        private System.Windows.Forms.Button add_g_param;
        private System.Windows.Forms.ListBox g_param_list;
    }
}