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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.eventListView = new System.Windows.Forms.ListView();
            this.eventColomunHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.axCadEvMgr60 = new AxCadevmgrLib60.AxCadEvMgr60();
            this.axMGDSListener = new AxCadevmgrLib60.AxMGDSListener();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axCadEvMgr60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMGDSListener)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventColomunHeader,
            this.detailColumnHeader});
            this.eventListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventListView.Location = new System.Drawing.Point(0, 24);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(684, 637);
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
            this.detailColumnHeader.Width = 500;
            // 
            // axCadEvMgr60
            // 
            this.axCadEvMgr60.Enabled = true;
            this.axCadEvMgr60.Location = new System.Drawing.Point(0, 0);
            this.axCadEvMgr60.Name = "axCadEvMgr60";
            this.axCadEvMgr60.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCadEvMgr60.OcxState")));
            this.axCadEvMgr60.Size = new System.Drawing.Size(27, 27);
            this.axCadEvMgr60.TabIndex = 1;
            this.axCadEvMgr60.Visible = false;
            this.axCadEvMgr60.MgdsActivate += new AxCadevmgrLib60._DCadEvMgrEvents60_MgdsActivateEventHandler(this.axCadEvMgr60_MgdsActivate);
            this.axCadEvMgr60.MgdsClose += new System.EventHandler(this.axCadEvMgr60_MgdsClose);
            this.axCadEvMgr60.MgdsPosition += new AxCadevmgrLib60._DCadEvMgrEvents60_MgdsPositionEventHandler(this.axCadEvMgr60_MgdsPosition);
            this.axCadEvMgr60.CurDocChange += new AxCadevmgrLib60._DCadEvMgrEvents60_CurDocChangeEventHandler(this.axCadEvMgr60_CurDocChange);
            this.axCadEvMgr60.CurDocClose += new AxCadevmgrLib60._DCadEvMgrEvents60_CurDocCloseEventHandler(this.axCadEvMgr60_CurDocClose);
            this.axCadEvMgr60.CurViewChange += new AxCadevmgrLib60._DCadEvMgrEvents60_CurViewChangeEventHandler(this.axCadEvMgr60_CurViewChange);
            this.axCadEvMgr60.CurViewClose += new AxCadevmgrLib60._DCadEvMgrEvents60_CurViewCloseEventHandler(this.axCadEvMgr60_CurViewClose);
            this.axCadEvMgr60.CurViewSave += new AxCadevmgrLib60._DCadEvMgrEvents60_CurViewSaveEventHandler(this.axCadEvMgr60_CurViewSave);
            this.axCadEvMgr60.CurViewExtents += new AxCadevmgrLib60._DCadEvMgrEvents60_CurViewExtentsEventHandler(this.axCadEvMgr60_CurViewExtents);
            this.axCadEvMgr60.EditDelete += new System.EventHandler(this.axCadEvMgr60_EditDelete);
            this.axCadEvMgr60.EditPlaceItem += new System.EventHandler(this.axCadEvMgr60_EditPlaceItem);
            this.axCadEvMgr60.LayerName += new AxCadevmgrLib60._DCadEvMgrEvents60_LayerNameEventHandler(this.axCadEvMgr60_LayerName);
            this.axCadEvMgr60.LayerOwnership += new AxCadevmgrLib60._DCadEvMgrEvents60_LayerOwnershipEventHandler(this.axCadEvMgr60_LayerOwnership);
            this.axCadEvMgr60.LayerUpdate += new System.EventHandler(this.axCadEvMgr60_LayerUpdate);
            this.axCadEvMgr60.CurPhase += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseEventHandler(this.axCadEvMgr60_CurPhase);
            this.axCadEvMgr60.CurPhaseStatus += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseStatusEventHandler(this.axCadEvMgr60_CurPhaseStatus);
            this.axCadEvMgr60.CurPhaseColour += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseColourEventHandler(this.axCadEvMgr60_CurPhaseColour);
            this.axCadEvMgr60.CurPhaseInclusion += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseInclusionEventHandler(this.axCadEvMgr60_CurPhaseInclusion);
            this.axCadEvMgr60.CurPhaseLineStyle += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseLineStyleEventHandler(this.axCadEvMgr60_CurPhaseLineStyle);
            this.axCadEvMgr60.CurPhaseCharStyle += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseCharStyleEventHandler(this.axCadEvMgr60_CurPhaseCharStyle);
            this.axCadEvMgr60.CurPhasePen += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhasePenEventHandler(this.axCadEvMgr60_CurPhasePen);
            this.axCadEvMgr60.SelectionList += new AxCadevmgrLib60._DCadEvMgrEvents60_SelectionListEventHandler(this.axCadEvMgr60_SelectionList);
            this.axCadEvMgr60.SelectionMode += new AxCadevmgrLib60._DCadEvMgrEvents60_SelectionModeEventHandler(this.axCadEvMgr60_SelectionMode);
            this.axCadEvMgr60.Snap += new AxCadevmgrLib60._DCadEvMgrEvents60_SnapEventHandler(this.axCadEvMgr60_Snap);
            this.axCadEvMgr60.SetAxes += new AxCadevmgrLib60._DCadEvMgrEvents60_SetAxesEventHandler(this.axCadEvMgr60_SetAxes);
            this.axCadEvMgr60.SetCharStyle += new AxCadevmgrLib60._DCadEvMgrEvents60_SetCharStyleEventHandler(this.axCadEvMgr60_SetCharStyle);
            this.axCadEvMgr60.SetLayer += new AxCadevmgrLib60._DCadEvMgrEvents60_SetLayerEventHandler(this.axCadEvMgr60_SetLayer);
            this.axCadEvMgr60.SetLineStyle += new AxCadevmgrLib60._DCadEvMgrEvents60_SetLineStyleEventHandler(this.axCadEvMgr60_SetLineStyle);
            this.axCadEvMgr60.SetObject += new AxCadevmgrLib60._DCadEvMgrEvents60_SetObjectEventHandler(this.axCadEvMgr60_SetObject);
            this.axCadEvMgr60.SetUnits += new AxCadevmgrLib60._DCadEvMgrEvents60_SetUnitsEventHandler(this.axCadEvMgr60_SetUnits);
            this.axCadEvMgr60.SetEditObject += new AxCadevmgrLib60._DCadEvMgrEvents60_SetEditObjectEventHandler(this.axCadEvMgr60_SetEditObject);
            this.axCadEvMgr60.SetEditLineStyle += new AxCadevmgrLib60._DCadEvMgrEvents60_SetEditLineStyleEventHandler(this.axCadEvMgr60_SetEditLineStyle);
            this.axCadEvMgr60.SetEditCharStyle += new AxCadevmgrLib60._DCadEvMgrEvents60_SetEditCharStyleEventHandler(this.axCadEvMgr60_SetEditCharStyle);
            this.axCadEvMgr60.SetEditMaterial += new AxCadevmgrLib60._DCadEvMgrEvents60_SetEditMaterialEventHandler(this.axCadEvMgr60_SetEditMaterial);
            this.axCadEvMgr60.CustomMenu += new AxCadevmgrLib60._DCadEvMgrEvents60_CustomMenuEventHandler(this.axCadEvMgr60_CustomMenu);
            this.axCadEvMgr60.CommandStart += new AxCadevmgrLib60._DCadEvMgrEvents60_CommandStartEventHandler(this.axCadEvMgr60_CommandStart);
            this.axCadEvMgr60.CommandEnd += new AxCadevmgrLib60._DCadEvMgrEvents60_CommandEndEventHandler(this.axCadEvMgr60_CommandEnd);
            this.axCadEvMgr60.PrintStart += new AxCadevmgrLib60._DCadEvMgrEvents60_PrintStartEventHandler(this.axCadEvMgr60_PrintStart);
            this.axCadEvMgr60.PrintEnd += new System.EventHandler(this.axCadEvMgr60_PrintEnd);
            this.axCadEvMgr60.CommandCallback += new AxCadevmgrLib60._DCadEvMgrEvents60_CommandCallbackEventHandler(this.axCadEvMgr60_CommandCallback);
            this.axCadEvMgr60.CommandKeyCallback += new AxCadevmgrLib60._DCadEvMgrEvents60_CommandKeyCallbackEventHandler(this.axCadEvMgr60_CommandKeyCallback);
            this.axCadEvMgr60.CustomMenuPopup += new AxCadevmgrLib60._DCadEvMgrEvents60_CustomMenuPopupEventHandler(this.axCadEvMgr60_CustomMenuPopup);
            this.axCadEvMgr60.CustomControl += new AxCadevmgrLib60._DCadEvMgrEvents60_CustomControlEventHandler(this.axCadEvMgr60_CustomControl);
            this.axCadEvMgr60.CustomCommand += new AxCadevmgrLib60._DCadEvMgrEvents60_CustomCommandEventHandler(this.axCadEvMgr60_CustomCommand);
            this.axCadEvMgr60.DynamicPos += new AxCadevmgrLib60._DCadEvMgrEvents60_DynamicPosEventHandler(this.axCadEvMgr60_DynamicPos);
            this.axCadEvMgr60.CurPhaseLink += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseLinkEventHandler(this.axCadEvMgr60_CurPhaseLink);
            this.axCadEvMgr60.SetEditColour += new AxCadevmgrLib60._DCadEvMgrEvents60_SetEditColourEventHandler(this.axCadEvMgr60_SetEditColour);
            this.axCadEvMgr60.CurPhaseMaterial += new AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseMaterialEventHandler(this.axCadEvMgr60_CurPhaseMaterial);
            // 
            // axMGDSListener
            // 
            this.axMGDSListener.Enabled = true;
            this.axMGDSListener.Location = new System.Drawing.Point(0, 0);
            this.axMGDSListener.Name = "axMGDSListener";
            this.axMGDSListener.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMGDSListener.OcxState")));
            this.axMGDSListener.Size = new System.Drawing.Size(100, 50);
            this.axMGDSListener.TabIndex = 2;
            this.axMGDSListener.Visible = false;
            this.axMGDSListener.MicroGDSStart += new AxCadevmgrLib60._DMGDSListenerEvents_MicroGDSStartEventHandler(this.axMGDSListener_MicroGDSStart);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileStripMenuItem.Text = "ファイル(&F)";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem.Text = "設定(&S)";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "閉じる(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.aboutToolStripMenuItem.Text = "MicroGDS Event Manager のバージョン情報(&A)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.eventListView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axCadEvMgr60);
            this.Controls.Add(this.axMGDSListener);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MicroGDSSpy";
            ((System.ComponentModel.ISupportInitialize)(this.axCadEvMgr60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMGDSListener)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader eventColomunHeader;
        private System.Windows.Forms.ColumnHeader detailColumnHeader;
        private AxCadevmgrLib60.AxCadEvMgr60 axCadEvMgr60;
        private AxCadevmgrLib60.AxMGDSListener axMGDSListener;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
    }
}

