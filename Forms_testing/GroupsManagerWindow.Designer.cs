namespace Forms_testing
{
    partial class GroupsManagerWindow
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
            this.GroupsList = new System.Windows.Forms.ListBox();
            this.GroupDataPanel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupNameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupDescriptionEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupCourseEdit = new System.Windows.Forms.NumericUpDown();
            this.GroupStudentsListBox = new System.Windows.Forms.ListBox();
            this.GroupDataPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCourseEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupsList
            // 
            this.GroupsList.FormattingEnabled = true;
            this.GroupsList.Location = new System.Drawing.Point(12, 12);
            this.GroupsList.Name = "GroupsList";
            this.GroupsList.Size = new System.Drawing.Size(290, 420);
            this.GroupsList.TabIndex = 0;
            this.GroupsList.SelectedIndexChanged += new System.EventHandler(this.GroupsList_SelectedIndexChanged);
            // 
            // GroupDataPanel
            // 
            this.GroupDataPanel.Controls.Add(this.GroupCourseEdit);
            this.GroupDataPanel.Controls.Add(this.groupBox1);
            this.GroupDataPanel.Controls.Add(this.GroupDescriptionEdit);
            this.GroupDataPanel.Controls.Add(this.label3);
            this.GroupDataPanel.Controls.Add(this.label2);
            this.GroupDataPanel.Controls.Add(this.GroupNameEdit);
            this.GroupDataPanel.Controls.Add(this.label1);
            this.GroupDataPanel.Location = new System.Drawing.Point(308, 12);
            this.GroupDataPanel.Name = "GroupDataPanel";
            this.GroupDataPanel.Size = new System.Drawing.Size(480, 426);
            this.GroupDataPanel.TabIndex = 1;
            this.GroupDataPanel.TabStop = false;
            this.GroupDataPanel.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // GroupNameEdit
            // 
            this.GroupNameEdit.Location = new System.Drawing.Point(86, 17);
            this.GroupNameEdit.Name = "GroupNameEdit";
            this.GroupNameEdit.Size = new System.Drawing.Size(388, 20);
            this.GroupNameEdit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер курса";
            // 
            // GroupDescriptionEdit
            // 
            this.GroupDescriptionEdit.Location = new System.Drawing.Point(86, 69);
            this.GroupDescriptionEdit.Name = "GroupDescriptionEdit";
            this.GroupDescriptionEdit.Size = new System.Drawing.Size(388, 20);
            this.GroupDescriptionEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupStudentsListBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 325);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенты";
            // 
            // GroupCourseEdit
            // 
            this.GroupCourseEdit.Location = new System.Drawing.Point(86, 43);
            this.GroupCourseEdit.Name = "GroupCourseEdit";
            this.GroupCourseEdit.Size = new System.Drawing.Size(58, 20);
            this.GroupCourseEdit.TabIndex = 7;
            // 
            // GroupStudentsListBox
            // 
            this.GroupStudentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupStudentsListBox.FormattingEnabled = true;
            this.GroupStudentsListBox.Location = new System.Drawing.Point(3, 16);
            this.GroupStudentsListBox.Name = "GroupStudentsListBox";
            this.GroupStudentsListBox.Size = new System.Drawing.Size(458, 306);
            this.GroupStudentsListBox.TabIndex = 0;
            // 
            // GroupsManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupDataPanel);
            this.Controls.Add(this.GroupsList);
            this.Name = "GroupsManagerWindow";
            this.Text = "Группы";
            this.GroupDataPanel.ResumeLayout(false);
            this.GroupDataPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupCourseEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GroupsList;
        private System.Windows.Forms.GroupBox GroupDataPanel;
        private System.Windows.Forms.TextBox GroupDescriptionEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GroupCourseEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox GroupStudentsListBox;
    }
}