namespace ASMLight
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Header");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("start");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Write");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("WriteLn");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Text section", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("strText");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("strText");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("strText");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("strText");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Data section", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeSections = new System.Windows.Forms.TreeView();
            this.textCode = new System.Windows.Forms.ExtRichTextBox();
            this.toolStripSearch = new System.Windows.Forms.ToolStrip();
            this.lblSearchText = new System.Windows.Forms.ToolStripLabel();
            this.textFind = new System.Windows.Forms.ToolStripTextBox();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.btnSearchtype = new System.Windows.Forms.ToolStripButton();
            this.btnFindBackward = new System.Windows.Forms.ToolStripButton();
            this.btnFindForward = new System.Windows.Forms.ToolStripButton();
            this.lblStop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectall = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(621, 23);
            this.statusStrip.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(621, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveas,
            this.mnuExport});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "&File";
            // 
            // mnuSaveas
            // 
            this.mnuSaveas.Name = "mnuSaveas";
            this.mnuSaveas.Text = "Save project as...";
            this.mnuSaveas.Click += new System.EventHandler(this.saveProjectAs);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripSeparator3,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete,
            this.toolStripSeparator4,
            this.mnuSelectall});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "&Edit";
            this.mnuEdit.Click += new System.EventHandler(this.copy);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Text = "&Help";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnExport,
            this.toolStripSeparator2,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator1,
            this.btnUndo,
            this.btnRedo});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(621, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.splitContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 74);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainPanel.Size = new System.Drawing.Size(621, 348);
            this.mainPanel.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeSections);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textCode);
            this.splitContainer.Size = new System.Drawing.Size(615, 342);
            this.splitContainer.SplitterDistance = 140;
            this.splitContainer.TabIndex = 2;
            // 
            // treeSections
            // 
            this.treeSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSections.Location = new System.Drawing.Point(0, 0);
            this.treeSections.Name = "treeSections";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Header";
            treeNode22.Name = "Node3";
            treeNode22.Text = "start";
            treeNode23.Name = "Node4";
            treeNode23.Text = "Write";
            treeNode24.Name = "Node5";
            treeNode24.Text = "WriteLn";
            treeNode25.Name = "Node1";
            treeNode25.Text = "Text section";
            treeNode26.Name = "Node6";
            treeNode26.Text = "strText";
            treeNode27.Name = "Node7";
            treeNode27.Text = "strText";
            treeNode28.Name = "Node8";
            treeNode28.Text = "strText";
            treeNode29.Name = "Node9";
            treeNode29.Text = "strText";
            treeNode30.Name = "Node2";
            treeNode30.Text = "Data section";
            this.treeSections.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode30});
            this.treeSections.Size = new System.Drawing.Size(140, 342);
            this.treeSections.TabIndex = 3;
            // 
            // textCode
            // 
            this.textCode.AcceptsTab = true;
            this.textCode.AssemblyHighlight = true;
            this.textCode.BackColor = System.Drawing.SystemColors.Window;
            this.textCode.CommentColor = System.Drawing.Color.LimeGreen;
            this.textCode.DetectUrls = false;
            this.textCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCode.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCode.HideSelection = false;
            this.textCode.Location = new System.Drawing.Point(0, 0);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(471, 342);
            this.textCode.TabIndex = 0;
            this.textCode.Text = "";
            this.textCode.WordWrap = false;
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSearchText,
            this.textFind,
            this.btnSearchtype,
            this.btnFindBackward,
            this.btnFindForward,
            this.lblStop});
            this.toolStripSearch.Location = new System.Drawing.Point(0, 49);
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(621, 25);
            this.toolStripSearch.TabIndex = 1;
            // 
            // lblSearchText
            // 
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Text = "Quick find:";
            // 
            // textFind
            // 
            this.textFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(120, 25);
            this.textFind.Leave += new System.EventHandler(this.textFind_Leave);
            this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
            // 
            // mnuNew
            // 
            this.mnuNew.Image = ASMLight.Properties.Resources.new_document_16;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Text = "New project";
            this.mnuNew.Click += new System.EventHandler(this.newProject);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ASMLight.Properties.Resources.open_document_16;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.openProject);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = ASMLight.Properties.Resources.save_16;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Text = "Save project";
            this.mnuSave.Click += new System.EventHandler(this.saveProject);
            // 
            // mnuExport
            // 
            this.mnuExport.Image = ASMLight.Properties.Resources.save_green_16;
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Text = "Export to assembly";
            this.mnuExport.Click += new System.EventHandler(this.exportProject);
            // 
            // mnuUndo
            // 
            this.mnuUndo.Image = ASMLight.Properties.Resources.undo_square_16;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.Text = "Undo";
            this.mnuUndo.Click += new System.EventHandler(this.undo);
            // 
            // mnuRedo
            // 
            this.mnuRedo.Image = ASMLight.Properties.Resources.redo_square_16;
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.Text = "Redo";
            this.mnuRedo.Click += new System.EventHandler(this.redo);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ASMLight.Properties.Resources.new_document_16;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.ToolTipText = "New project";
            this.btnNew.Click += new System.EventHandler(this.newProject);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ASMLight.Properties.Resources.open_document_16;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ToolTipText = "Open...";
            this.btnOpen.Click += new System.EventHandler(this.openProject);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ASMLight.Properties.Resources.save_16;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.ToolTipText = "Save project";
            this.btnSave.Click += new System.EventHandler(this.saveProject);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ASMLight.Properties.Resources.save_green_16;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.ToolTipText = "Export to assembly";
            this.btnExport.Click += new System.EventHandler(this.exportProject);
            // 
            // btnCut
            // 
            this.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCut.Image = ASMLight.Properties.Resources.cut_clipboard_16;
            this.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCut.Name = "btnCut";
            this.btnCut.ToolTipText = "Cut";
            this.btnCut.Click += new System.EventHandler(this.cut);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Image = ASMLight.Properties.Resources.copy_clipboard_16;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ToolTipText = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.copy);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = ASMLight.Properties.Resources.paste_clipboard_16;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ToolTipText = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.paste);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = ASMLight.Properties.Resources.undo_square_16;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ToolTipText = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.undo);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = ASMLight.Properties.Resources.redo_square_16;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ToolTipText = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.redo);
            // 
            // btnSearchtype
            // 
            this.btnSearchtype.Checked = true;
            this.btnSearchtype.CheckOnClick = true;
            this.btnSearchtype.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSearchtype.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchtype.Image = ASMLight.Properties.Resources.properties_doc_16;
            this.btnSearchtype.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchtype.Name = "btnSearchtype";
            this.btnSearchtype.ToolTipText = "Search in the hole project";
            // 
            // btnFindBackward
            // 
            this.btnFindBackward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFindBackward.Enabled = false;
            this.btnFindBackward.Image = ASMLight.Properties.Resources.arrowleft_green_16;
            this.btnFindBackward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindBackward.Name = "btnFindBackward";
            this.btnFindBackward.ToolTipText = "Find backward";
            this.btnFindBackward.Click += new System.EventHandler(this.btnFindBackward_Click);
            // 
            // btnFindForward
            // 
            this.btnFindForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFindForward.Enabled = false;
            this.btnFindForward.Image = ASMLight.Properties.Resources.arrowright_green_16;
            this.btnFindForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindForward.Name = "btnFindForward";
            this.btnFindForward.ToolTipText = "Find forward";
            this.btnFindForward.Click += new System.EventHandler(this.btnFindForward_Click);
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = false;
            this.lblStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lblStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblStop.Image = ASMLight.Properties.Resources.stop_16;
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(16, 16);
            this.lblStop.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // mnuCut
            // 
            this.mnuCut.Image = ASMLight.Properties.Resources.cut_clipboard_16;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Text = "Cut";
            this.mnuCut.Click += new System.EventHandler(this.cut);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = ASMLight.Properties.Resources.copy_clipboard_16;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Text = "Copy";
            // 
            // mnuPaste
            // 
            this.mnuPaste.Image = ASMLight.Properties.Resources.paste_clipboard_16;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.Click += new System.EventHandler(this.paste);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.delete);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // mnuSelectall
            // 
            this.mnuSelectall.Name = "mnuSelectall";
            this.mnuSelectall.Text = "Select all";
            this.mnuSelectall.Click += new System.EventHandler(this.selectAll);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 445);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolStripSearch);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Name = "frmMain";
            this.Text = "ASM Light";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolStripSearch.ResumeLayout(false);
            this.toolStripSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStrip toolStripSearch;
        private System.Windows.Forms.ToolStripLabel lblSearchText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveas;
        private System.Windows.Forms.ToolStripTextBox textFind;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ExtRichTextBox textCode;
        private System.Windows.Forms.TreeView treeSections;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripButton btnSearchtype;
        private System.Windows.Forms.ToolStripButton btnFindBackward;
        private System.Windows.Forms.ToolStripButton btnFindForward;
        private System.Windows.Forms.ToolStripLabel lblStop;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectall;
    }
}

