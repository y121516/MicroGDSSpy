namespace MicroGDSSpy
{
    partial class MainForm
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
            this.eventListView = new System.Windows.Forms.ListView();
            this.eventColomunHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventColomunHeader,
            this.detailColumnHeader});
            this.eventListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventListView.Location = new System.Drawing.Point(0, 0);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(284, 261);
            this.eventListView.TabIndex = 0;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            // 
            // eventColomunHeader
            // 
            this.eventColomunHeader.Text = "イベント";
            this.eventColomunHeader.Width = 118;
            // 
            // detailColumnHeader
            // 
            this.detailColumnHeader.Text = "詳細";
            this.detailColumnHeader.Width = 162;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.eventListView);
            this.Name = "MainForm";
            this.Text = "MicroGDSSpy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader eventColomunHeader;
        private System.Windows.Forms.ColumnHeader detailColumnHeader;
    }
}

