
namespace Dz13
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.cookPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadPictureBox = new System.Windows.Forms.PictureBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cookPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Controls.Add(this.cookPictureBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer.Size = new System.Drawing.Size(907, 575);
            this.splitContainer.SplitterDistance = 162;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(12, 161);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(137, 391);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.peoplesTreeViewNodeMouseClick);
            // 
            // cookPictureBox
            // 
            this.cookPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cookPictureBox.Image")));
            this.cookPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cookPictureBox.Name = "cookPictureBox";
            this.cookPictureBox.Size = new System.Drawing.Size(137, 130);
            this.cookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cookPictureBox.TabIndex = 0;
            this.cookPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.exitBtn);
            this.groupBox3.Location = new System.Drawing.Point(513, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dz13.Properties.Resources.exit;
            this.pictureBox3.Location = new System.Drawing.Point(6, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(47, 11);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 33);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showPictureBox);
            this.groupBox2.Controls.Add(this.showBtn);
            this.groupBox2.Location = new System.Drawing.Point(278, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // showPictureBox
            // 
            this.showPictureBox.Image = global::Dz13.Properties.Resources.fold1;
            this.showPictureBox.Location = new System.Drawing.Point(6, 11);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(35, 33);
            this.showPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPictureBox.TabIndex = 1;
            this.showPictureBox.TabStop = false;
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showBtn.Location = new System.Drawing.Point(47, 11);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(132, 33);
            this.showBtn.TabIndex = 0;
            this.showBtn.Text = "Показать";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downloadPictureBox);
            this.groupBox1.Controls.Add(this.downloadBtn);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // downloadPictureBox
            // 
            this.downloadPictureBox.Image = global::Dz13.Properties.Resources.down;
            this.downloadPictureBox.Location = new System.Drawing.Point(6, 11);
            this.downloadPictureBox.Name = "downloadPictureBox";
            this.downloadPictureBox.Size = new System.Drawing.Size(35, 33);
            this.downloadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downloadPictureBox.TabIndex = 1;
            this.downloadPictureBox.TabStop = false;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadBtn.Location = new System.Drawing.Point(47, 11);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(132, 33);
            this.downloadBtn.TabIndex = 0;
            this.downloadBtn.Text = "Загрузить";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 469);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 575);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(923, 614);
            this.MinimumSize = new System.Drawing.Size(923, 614);
            this.Name = "MainForm";
            this.Text = "Cooking classes";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cookPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox cookPictureBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox downloadPictureBox;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox showPictureBox;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

