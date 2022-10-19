namespace Tablet
{
    partial class Spreadsheet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spreadsheet));
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteARowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNotesStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addRow = new System.Windows.Forms.Button();
            this.addColumn = new System.Windows.Forms.Button();
            this.resultOfCell = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteRows = new System.Windows.Forms.Button();
            this.deleteColumns = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.BackColor = System.Drawing.Color.White;
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.Location = new System.Drawing.Point(915, 39);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(146, 71);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(915, 524);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 66);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitStrip,
            this.helpStrip,
            this.aboutStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitStrip
            // 
            this.exitStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.undoStrip,
            this.makeNotesStrip,
            this.exitToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.exitStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitStrip.Image = ((System.Drawing.Image)(resources.GetObject("exitStrip.Image")));
            this.exitStrip.Name = "exitStrip";
            this.exitStrip.Size = new System.Drawing.Size(77, 32);
            this.exitStrip.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnStrip,
            this.addRowToolStripMenuItem,
            this.deleteColumnToolStripMenuItem,
            this.deleteARowToolStripMenuItem});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.newToolStripMenuItem.Text = "New";
            // 
            // addColumnStrip
            // 
            this.addColumnStrip.Image = ((System.Drawing.Image)(resources.GetObject("addColumnStrip.Image")));
            this.addColumnStrip.Name = "addColumnStrip";
            this.addColumnStrip.Size = new System.Drawing.Size(231, 32);
            this.addColumnStrip.Text = "Add column";
            this.addColumnStrip.Click += new System.EventHandler(this.addColumnStrip_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addRowToolStripMenuItem.Image")));
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.addRowToolStripMenuItem.Text = "Add row";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumnToolStripMenuItem.Image")));
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.deleteColumnToolStripMenuItem.Text = "Delete column";
            this.deleteColumnToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem_Click);
            // 
            // deleteARowToolStripMenuItem
            // 
            this.deleteARowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteARowToolStripMenuItem.Image")));
            this.deleteARowToolStripMenuItem.Name = "deleteARowToolStripMenuItem";
            this.deleteARowToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.deleteARowToolStripMenuItem.Text = "Delete a row";
            // 
            // undoStrip
            // 
            this.undoStrip.Image = ((System.Drawing.Image)(resources.GetObject("undoStrip.Image")));
            this.undoStrip.Name = "undoStrip";
            this.undoStrip.Size = new System.Drawing.Size(205, 32);
            this.undoStrip.Text = "Undo";
            // 
            // makeNotesStrip
            // 
            this.makeNotesStrip.Image = ((System.Drawing.Image)(resources.GetObject("makeNotesStrip.Image")));
            this.makeNotesStrip.Name = "makeNotesStrip";
            this.makeNotesStrip.Size = new System.Drawing.Size(205, 32);
            this.makeNotesStrip.Text = "Make notes";
            this.makeNotesStrip.Click += new System.EventHandler(this.makeNotesStrip_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.clearToolStripMenuItem.Text = "Clear ";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpStrip
            // 
            this.helpStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpStrip.Image = ((System.Drawing.Image)(resources.GetObject("helpStrip.Image")));
            this.helpStrip.Name = "helpStrip";
            this.helpStrip.Size = new System.Drawing.Size(89, 32);
            this.helpStrip.Text = "Help";
            this.helpStrip.Click += new System.EventHandler(this.helpStrip_Click);
            // 
            // aboutStrip
            // 
            this.aboutStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutStrip.Image = ((System.Drawing.Image)(resources.GetObject("aboutStrip.Image")));
            this.aboutStrip.Name = "aboutStrip";
            this.aboutStrip.Size = new System.Drawing.Size(102, 32);
            this.aboutStrip.Text = "About";
            this.aboutStrip.Click += new System.EventHandler(this.aboutStrip_Click);
            // 
            // addRow
            // 
            this.addRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRow.BackColor = System.Drawing.Color.White;
            this.addRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addRow.Image = ((System.Drawing.Image)(resources.GetObject("addRow.Image")));
            this.addRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRow.Location = new System.Drawing.Point(49, 524);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(133, 66);
            this.addRow.TabIndex = 3;
            this.addRow.Text = "Add row";
            this.addRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addRow.UseVisualStyleBackColor = false;
            this.addRow.Click += new System.EventHandler(this.button1_Click);
            // 
            // addColumn
            // 
            this.addColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addColumn.BackColor = System.Drawing.Color.White;
            this.addColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addColumn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addColumn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addColumn.Image = ((System.Drawing.Image)(resources.GetObject("addColumn.Image")));
            this.addColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addColumn.Location = new System.Drawing.Point(197, 524);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(141, 66);
            this.addColumn.TabIndex = 4;
            this.addColumn.Text = "Add column";
            this.addColumn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addColumn.UseVisualStyleBackColor = false;
            this.addColumn.Click += new System.EventHandler(this.addColumn_Click);
            // 
            // resultOfCell
            // 
            this.resultOfCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultOfCell.Location = new System.Drawing.Point(59, 400);
            this.resultOfCell.Multiline = true;
            this.resultOfCell.Name = "resultOfCell";
            this.resultOfCell.Size = new System.Drawing.Size(263, 54);
            this.resultOfCell.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(344, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(49, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(825, 294);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // deleteRows
            // 
            this.deleteRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteRows.BackColor = System.Drawing.Color.White;
            this.deleteRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteRows.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteRows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteRows.Image = ((System.Drawing.Image)(resources.GetObject("deleteRows.Image")));
            this.deleteRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteRows.Location = new System.Drawing.Point(49, 460);
            this.deleteRows.Name = "deleteRows";
            this.deleteRows.Size = new System.Drawing.Size(133, 66);
            this.deleteRows.TabIndex = 9;
            this.deleteRows.Text = "Delete row";
            this.deleteRows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteRows.UseVisualStyleBackColor = false;
            this.deleteRows.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteColumns
            // 
            this.deleteColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteColumns.BackColor = System.Drawing.Color.White;
            this.deleteColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteColumns.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteColumns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteColumns.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumns.Image")));
            this.deleteColumns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteColumns.Location = new System.Drawing.Point(199, 460);
            this.deleteColumns.Name = "deleteColumns";
            this.deleteColumns.Size = new System.Drawing.Size(139, 66);
            this.deleteColumns.TabIndex = 10;
            this.deleteColumns.Text = "Delete column";
            this.deleteColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteColumns.UseVisualStyleBackColor = false;
            this.deleteColumns.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Spreadsheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1073, 602);
            this.Controls.Add(this.deleteColumns);
            this.Controls.Add(this.deleteRows);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.resultOfCell);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spreadsheet";
            this.Text = "Spreadsheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openButton;
        private Button saveButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitStrip;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem addColumnStrip;
        private ToolStripMenuItem addRowToolStripMenuItem;
        private ToolStripMenuItem deleteColumnToolStripMenuItem;
        private ToolStripMenuItem deleteARowToolStripMenuItem;
        private ToolStripMenuItem undoStrip;
        private ToolStripMenuItem makeNotesStrip;
        private ToolStripMenuItem helpStrip;
        private ToolStripMenuItem aboutStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button addRow;
        private Button addColumn;
        private TextBox resultOfCell;
        private ToolStripMenuItem clearToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private Button button1;
        private DataGridView dataGridView;
        private Button deleteRows;
        private Button deleteColumns;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}