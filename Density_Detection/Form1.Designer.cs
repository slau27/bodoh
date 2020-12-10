namespace Density_Detection
{
    partial class Form1
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
            this.image_Original = new System.Windows.Forms.PictureBox();
            this.button_Upload = new System.Windows.Forms.Button();
            this.image_Bw = new System.Windows.Forms.PictureBox();
            this.lbl_Originalimage = new System.Windows.Forms.Label();
            this.lbl_Adjusted = new System.Windows.Forms.Label();
            this.btn_bw = new System.Windows.Forms.Button();
            this.txt_Gvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Density = new System.Windows.Forms.Label();
            this.lbl_fileName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_areaAround = new System.Windows.Forms.Button();
            this.btn_indi = new System.Windows.Forms.Button();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_yRect = new System.Windows.Forms.TextBox();
            this.txt_xRect = new System.Windows.Forms.TextBox();
            this.label_rect = new System.Windows.Forms.Label();
            this.lbl_Coor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Bw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // image_Original
            // 
            this.image_Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_Original.Cursor = System.Windows.Forms.Cursors.Cross;
            this.image_Original.Location = new System.Drawing.Point(12, 15);
            this.image_Original.Margin = new System.Windows.Forms.Padding(4);
            this.image_Original.Name = "image_Original";
            this.image_Original.Size = new System.Drawing.Size(600, 600);
            this.image_Original.TabIndex = 0;
            this.image_Original.TabStop = false;
            this.image_Original.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_Original_MouseClick);
            this.image_Original.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_Original_MouseMove);
            // 
            // button_Upload
            // 
            this.button_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Upload.Location = new System.Drawing.Point(306, 626);
            this.button_Upload.Margin = new System.Windows.Forms.Padding(4);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(220, 74);
            this.button_Upload.TabIndex = 2;
            this.button_Upload.Text = "Upload photo";
            this.button_Upload.UseVisualStyleBackColor = true;
            this.button_Upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // image_Bw
            // 
            this.image_Bw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_Bw.Cursor = System.Windows.Forms.Cursors.Cross;
            this.image_Bw.Location = new System.Drawing.Point(620, 15);
            this.image_Bw.Margin = new System.Windows.Forms.Padding(4);
            this.image_Bw.Name = "image_Bw";
            this.image_Bw.Size = new System.Drawing.Size(600, 600);
            this.image_Bw.TabIndex = 3;
            this.image_Bw.TabStop = false;
            this.image_Bw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_Bw_MouseClick);
            this.image_Bw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_Bw_MouseMove);
            // 
            // lbl_Originalimage
            // 
            this.lbl_Originalimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Originalimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Originalimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Originalimage.Location = new System.Drawing.Point(134, 630);
            this.lbl_Originalimage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Originalimage.Name = "lbl_Originalimage";
            this.lbl_Originalimage.Size = new System.Drawing.Size(346, 24);
            this.lbl_Originalimage.TabIndex = 17;
            this.lbl_Originalimage.Text = "Original Image";
            this.lbl_Originalimage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Originalimage.Visible = false;
            // 
            // lbl_Adjusted
            // 
            this.lbl_Adjusted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Adjusted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adjusted.Location = new System.Drawing.Point(762, 626);
            this.lbl_Adjusted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adjusted.Name = "lbl_Adjusted";
            this.lbl_Adjusted.Size = new System.Drawing.Size(346, 24);
            this.lbl_Adjusted.TabIndex = 18;
            this.lbl_Adjusted.Text = "Black/Green Image";
            this.lbl_Adjusted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Adjusted.Visible = false;
            // 
            // btn_bw
            // 
            this.btn_bw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bw.Location = new System.Drawing.Point(828, 623);
            this.btn_bw.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bw.Name = "btn_bw";
            this.btn_bw.Size = new System.Drawing.Size(220, 74);
            this.btn_bw.TabIndex = 25;
            this.btn_bw.Text = "Convert to black";
            this.btn_bw.UseVisualStyleBackColor = true;
            this.btn_bw.Click += new System.EventHandler(this.btn_bw_Click);
            // 
            // txt_Gvalue
            // 
            this.txt_Gvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gvalue.Location = new System.Drawing.Point(924, 742);
            this.txt_Gvalue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Gvalue.Name = "txt_Gvalue";
            this.txt_Gvalue.Size = new System.Drawing.Size(132, 30);
            this.txt_Gvalue.TabIndex = 26;
            this.txt_Gvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Gvalue.TextChanged += new System.EventHandler(this.txt_Gvalue_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(774, 713);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 92);
            this.label1.TabIndex = 27;
            this.label1.Text = "G Value less than or equal to this will be black";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 790);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 74);
            this.button1.TabIndex = 28;
            this.button1.Text = "Clear Markings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 771);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "G value 0 to 255";
            // 
            // lbl_Density
            // 
            this.lbl_Density.AutoSize = true;
            this.lbl_Density.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Density.Location = new System.Drawing.Point(850, 810);
            this.lbl_Density.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Density.Name = "lbl_Density";
            this.lbl_Density.Size = new System.Drawing.Size(156, 27);
            this.lbl_Density.TabIndex = 33;
            this.lbl_Density.Text = "Noise Area % = ";
            // 
            // lbl_fileName
            // 
            this.lbl_fileName.AutoSize = true;
            this.lbl_fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileName.Location = new System.Drawing.Point(620, 15);
            this.lbl_fileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fileName.Name = "lbl_fileName";
            this.lbl_fileName.Size = new System.Drawing.Size(2, 27);
            this.lbl_fileName.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.G});
            this.dataGridView1.Location = new System.Drawing.Point(239, 717);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 147);
            this.dataGridView1.TabIndex = 44;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // G
            // 
            this.G.HeaderText = "G value";
            this.G.Name = "G";
            // 
            // btn_areaAround
            // 
            this.btn_areaAround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areaAround.Location = new System.Drawing.Point(11, 626);
            this.btn_areaAround.Margin = new System.Windows.Forms.Padding(4);
            this.btn_areaAround.Name = "btn_areaAround";
            this.btn_areaAround.Size = new System.Drawing.Size(220, 74);
            this.btn_areaAround.TabIndex = 45;
            this.btn_areaAround.Text = "Surrounding area";
            this.btn_areaAround.UseVisualStyleBackColor = true;
            this.btn_areaAround.Click += new System.EventHandler(this.btn_areaAround_Click);
            // 
            // btn_indi
            // 
            this.btn_indi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indi.Location = new System.Drawing.Point(11, 708);
            this.btn_indi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indi.Name = "btn_indi";
            this.btn_indi.Size = new System.Drawing.Size(220, 74);
            this.btn_indi.TabIndex = 46;
            this.btn_indi.Text = "Indication";
            this.btn_indi.UseVisualStyleBackColor = true;
            this.btn_indi.Click += new System.EventHandler(this.btn_indi_Click);
            // 
            // txt_width
            // 
            this.txt_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_width.Location = new System.Drawing.Point(665, 790);
            this.txt_width.Margin = new System.Windows.Forms.Padding(4);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(75, 30);
            this.txt_width.TabIndex = 47;
            this.txt_width.Text = "100";
            this.txt_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_height
            // 
            this.txt_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(665, 825);
            this.txt_height.Margin = new System.Windows.Forms.Padding(4);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(75, 30);
            this.txt_height.TabIndex = 48;
            this.txt_height.Text = "50";
            this.txt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 793);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Width";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 828);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 755);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 720);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_yRect
            // 
            this.txt_yRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yRect.Location = new System.Drawing.Point(665, 752);
            this.txt_yRect.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yRect.Name = "txt_yRect";
            this.txt_yRect.Size = new System.Drawing.Size(75, 30);
            this.txt_yRect.TabIndex = 52;
            this.txt_yRect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_xRect
            // 
            this.txt_xRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xRect.Location = new System.Drawing.Point(665, 717);
            this.txt_xRect.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xRect.Name = "txt_xRect";
            this.txt_xRect.Size = new System.Drawing.Size(75, 30);
            this.txt_xRect.TabIndex = 51;
            this.txt_xRect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_rect
            // 
            this.label_rect.AutoSize = true;
            this.label_rect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rect.Location = new System.Drawing.Point(850, 842);
            this.label_rect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rect.Name = "label_rect";
            this.label_rect.Size = new System.Drawing.Size(214, 27);
            this.label_rect.TabIndex = 55;
            this.label_rect.Text = "Noise Area % (Rect) = ";
            // 
            // lbl_Coor
            // 
            this.lbl_Coor.AutoSize = true;
            this.lbl_Coor.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Coor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Coor.Location = new System.Drawing.Point(573, 626);
            this.lbl_Coor.Name = "lbl_Coor";
            this.lbl_Coor.Size = new System.Drawing.Size(112, 19);
            this.lbl_Coor.TabIndex = 56;
            this.lbl_Coor.Text = "X:____   Y:____";
            this.lbl_Coor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1228, 879);
            this.Controls.Add(this.lbl_Coor);
            this.Controls.Add(this.label_rect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_yRect);
            this.Controls.Add(this.txt_xRect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.btn_indi);
            this.Controls.Add(this.btn_areaAround);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_fileName);
            this.Controls.Add(this.lbl_Density);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Gvalue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bw);
            this.Controls.Add(this.lbl_Adjusted);
            this.Controls.Add(this.lbl_Originalimage);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.image_Original);
            this.Controls.Add(this.image_Bw);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Bw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_Original;
        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.PictureBox image_Bw;
        private System.Windows.Forms.Label lbl_Originalimage;
        private System.Windows.Forms.Label lbl_Adjusted;
        private System.Windows.Forms.Button btn_bw;
        private System.Windows.Forms.TextBox txt_Gvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Density;
        private System.Windows.Forms.Label lbl_fileName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.Button btn_areaAround;
        private System.Windows.Forms.Button btn_indi;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_yRect;
        private System.Windows.Forms.TextBox txt_xRect;
        private System.Windows.Forms.Label label_rect;
        private System.Windows.Forms.Label lbl_Coor;
    }
}

