namespace DiceWarsGame
{
    partial class PlayerListForm
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
            components = new System.ComponentModel.Container();
            dgv = new DataGridView();
            cbxSearch = new ComboBox();
            tbxSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            cbxSort = new ComboBox();
            btnSort = new Button();
            btnEdit = new Button();
            playerBindingSource = new BindingSource(components);
            plid15933DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plname15933DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plispvpenabled15933DataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            pllastgamedate15933DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plscore15933DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { plid15933DataGridViewTextBoxColumn, plname15933DataGridViewTextBoxColumn, plispvpenabled15933DataGridViewCheckBoxColumn, pllastgamedate15933DataGridViewTextBoxColumn, plscore15933DataGridViewTextBoxColumn });
            dgv.DataSource = playerBindingSource;
            dgv.Location = new Point(24, 33);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(664, 341);
            dgv.TabIndex = 0;
            // 
            // cbxSearch
            // 
            cbxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbxSearch.FormattingEnabled = true;
            cbxSearch.Location = new Point(41, 409);
            cbxSearch.Name = "cbxSearch";
            cbxSearch.Size = new Size(212, 23);
            cbxSearch.TabIndex = 1;
            // 
            // tbxSearch
            // 
            tbxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxSearch.Location = new Point(259, 409);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(125, 23);
            tbxSearch.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(701, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(701, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(701, 156);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 35);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.Location = new Point(406, 409);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbxSort
            // 
            cbxSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbxSort.FormattingEnabled = true;
            cbxSort.Location = new Point(41, 380);
            cbxSort.Name = "cbxSort";
            cbxSort.Size = new Size(343, 23);
            cbxSort.TabIndex = 8;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSort.Location = new Point(406, 380);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(113, 23);
            btnSort.TabIndex = 9;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(701, 74);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 35);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(DAL.Player);
            // 
            // plid15933DataGridViewTextBoxColumn
            // 
            plid15933DataGridViewTextBoxColumn.DataPropertyName = "pl_id_15933";
            plid15933DataGridViewTextBoxColumn.HeaderText = "pl_id_15933";
            plid15933DataGridViewTextBoxColumn.Name = "plid15933DataGridViewTextBoxColumn";
            // 
            // plname15933DataGridViewTextBoxColumn
            // 
            plname15933DataGridViewTextBoxColumn.DataPropertyName = "pl_name_15933";
            plname15933DataGridViewTextBoxColumn.HeaderText = "pl_name_15933";
            plname15933DataGridViewTextBoxColumn.Name = "plname15933DataGridViewTextBoxColumn";
            // 
            // plispvpenabled15933DataGridViewCheckBoxColumn
            // 
            plispvpenabled15933DataGridViewCheckBoxColumn.DataPropertyName = "pl_is_pvp_enabled_15933";
            plispvpenabled15933DataGridViewCheckBoxColumn.HeaderText = "pl_is_pvp_enabled_15933";
            plispvpenabled15933DataGridViewCheckBoxColumn.Name = "plispvpenabled15933DataGridViewCheckBoxColumn";
            // 
            // pllastgamedate15933DataGridViewTextBoxColumn
            // 
            pllastgamedate15933DataGridViewTextBoxColumn.DataPropertyName = "pl_last_game_date_15933";
            pllastgamedate15933DataGridViewTextBoxColumn.HeaderText = "pl_last_game_date_15933";
            pllastgamedate15933DataGridViewTextBoxColumn.Name = "pllastgamedate15933DataGridViewTextBoxColumn";
            // 
            // plscore15933DataGridViewTextBoxColumn
            // 
            plscore15933DataGridViewTextBoxColumn.DataPropertyName = "pl_score_15933";
            plscore15933DataGridViewTextBoxColumn.HeaderText = "pl_score_15933";
            plscore15933DataGridViewTextBoxColumn.Name = "plscore15933DataGridViewTextBoxColumn";
            // 
            // PlayerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 444);
            Controls.Add(btnEdit);
            Controls.Add(btnSort);
            Controls.Add(cbxSort);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbxSearch);
            Controls.Add(cbxSearch);
            Controls.Add(dgv);
            Name = "PlayerListForm";
            Text = "Player";
            Load += PlayerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private ComboBox cbxSearch;
        private TextBox tbxSearch;
        private Button btnAdd;
        private Button b;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnSearch;
        private ComboBox cbxSort;
        private Button btnSort;
        private Button btnEdit;
        private DataGridViewTextBoxColumn plid15933DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plname15933DataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn plispvpenabled15933DataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn pllastgamedate15933DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plscore15933DataGridViewTextBoxColumn;
        private BindingSource playerBindingSource;
    }
}