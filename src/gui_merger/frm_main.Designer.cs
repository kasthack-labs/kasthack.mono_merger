namespace gui_merger
{
    partial class frm_main
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
            this.tbc_root = new System.Windows.Forms.TabControl();
            this.tbp_settings = new System.Windows.Forms.TabPage();
            this.grp_new_session = new System.Windows.Forms.GroupBox();
            this.txt_commit_format = new gui_merger.Controls.RWScintilla();
            this.lbl_commit_format = new System.Windows.Forms.Label();
            this.lbl_a_path = new System.Windows.Forms.Label();
            this.txt_a_path = new System.Windows.Forms.TextBox();
            this.btn_browse_b_path = new System.Windows.Forms.Button();
            this.btn_browse_a_path = new System.Windows.Forms.Button();
            this.txt_b_path = new System.Windows.Forms.TextBox();
            this.lbl_b_path = new System.Windows.Forms.Label();
            this.btn_begin = new System.Windows.Forms.Button();
            this.tbp_merge = new System.Windows.Forms.TabPage();
            this.split_merge = new System.Windows.Forms.SplitContainer();
            this.split_spl = new System.Windows.Forms.SplitContainer();
            this.btn_sources_file_reload = new System.Windows.Forms.Button();
            this.btn_browse_to_sources_file = new System.Windows.Forms.Button();
            this.txt_sources_file = new gui_merger.Controls.RWScintilla();
            this.lbl_sources_file_path = new System.Windows.Forms.TextBox();
            this.lbl_sources_file = new System.Windows.Forms.Label();
            this.rd_review = new System.Windows.Forms.RadioButton();
            this.rd_rejected = new System.Windows.Forms.RadioButton();
            this.rd_merged = new System.Windows.Forms.RadioButton();
            this.rd_dft = new System.Windows.Forms.RadioButton();
            this.btn_save_state = new System.Windows.Forms.Button();
            this.btn_load_state = new System.Windows.Forms.Button();
            this.lbl_matches = new System.Windows.Forms.Label();
            this.lst_matches = new System.Windows.Forms.CheckedListBox();
            this.split_diff = new System.Windows.Forms.SplitContainer();
            this.btn_file_a_reload = new System.Windows.Forms.Button();
            this.btn_browse_to_file_a = new System.Windows.Forms.Button();
            this.txt_file_a = new gui_merger.Controls.RWScintilla();
            this.lbl_file_a_path = new System.Windows.Forms.TextBox();
            this.lbl_file_a = new System.Windows.Forms.Label();
            this.btn_file_b_reload = new System.Windows.Forms.Button();
            this.btn_browse_to_file_b = new System.Windows.Forms.Button();
            this.txt_file_b = new gui_merger.Controls.RWScintilla();
            this.lbl_file_b_path = new System.Windows.Forms.TextBox();
            this.lbl_file_b = new System.Windows.Forms.Label();
            this.tbp_output = new System.Windows.Forms.TabPage();
            this.btn_save_output = new System.Windows.Forms.Button();
            this.txt_output = new gui_merger.Controls.RWScintilla();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.tbc_root.SuspendLayout();
            this.tbp_settings.SuspendLayout();
            this.grp_new_session.SuspendLayout();
            this.tbp_merge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_merge)).BeginInit();
            this.split_merge.Panel1.SuspendLayout();
            this.split_merge.Panel2.SuspendLayout();
            this.split_merge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_spl)).BeginInit();
            this.split_spl.Panel1.SuspendLayout();
            this.split_spl.Panel2.SuspendLayout();
            this.split_spl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_diff)).BeginInit();
            this.split_diff.Panel1.SuspendLayout();
            this.split_diff.Panel2.SuspendLayout();
            this.split_diff.SuspendLayout();
            this.tbp_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_root
            // 
            this.tbc_root.Controls.Add(this.tbp_settings);
            this.tbc_root.Controls.Add(this.tbp_merge);
            this.tbc_root.Controls.Add(this.tbp_output);
            this.tbc_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_root.Location = new System.Drawing.Point(0, 0);
            this.tbc_root.Name = "tbc_root";
            this.tbc_root.SelectedIndex = 0;
            this.tbc_root.Size = new System.Drawing.Size(1066, 749);
            this.tbc_root.TabIndex = 0;
            this.tbc_root.SelectedIndexChanged += new System.EventHandler(this.tbc_root_SelectedIndexChanged);
            // 
            // tbp_settings
            // 
            this.tbp_settings.Controls.Add(this.grp_new_session);
            this.tbp_settings.Controls.Add(this.btn_begin);
            this.tbp_settings.Location = new System.Drawing.Point(4, 22);
            this.tbp_settings.Name = "tbp_settings";
            this.tbp_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_settings.Size = new System.Drawing.Size(1058, 723);
            this.tbp_settings.TabIndex = 0;
            this.tbp_settings.Text = "Settings";
            this.tbp_settings.UseVisualStyleBackColor = true;
            // 
            // grp_new_session
            // 
            this.grp_new_session.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_new_session.Controls.Add(this.txt_commit_format);
            this.grp_new_session.Controls.Add(this.lbl_commit_format);
            this.grp_new_session.Controls.Add(this.lbl_a_path);
            this.grp_new_session.Controls.Add(this.txt_a_path);
            this.grp_new_session.Controls.Add(this.btn_browse_b_path);
            this.grp_new_session.Controls.Add(this.btn_browse_a_path);
            this.grp_new_session.Controls.Add(this.txt_b_path);
            this.grp_new_session.Controls.Add(this.lbl_b_path);
            this.grp_new_session.Location = new System.Drawing.Point(8, 16);
            this.grp_new_session.Name = "grp_new_session";
            this.grp_new_session.Size = new System.Drawing.Size(1039, 511);
            this.grp_new_session.TabIndex = 10;
            this.grp_new_session.TabStop = false;
            this.grp_new_session.Text = "New session";
            // 
            // txt_commit_format
            // 
            this.txt_commit_format.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_commit_format.Location = new System.Drawing.Point(15, 192);
            this.txt_commit_format.Name = "txt_commit_format";
            this.txt_commit_format.Size = new System.Drawing.Size(978, 295);
            this.txt_commit_format.TabIndex = 7;
            // 
            // lbl_commit_format
            // 
            this.lbl_commit_format.AutoSize = true;
            this.lbl_commit_format.Location = new System.Drawing.Point(12, 164);
            this.lbl_commit_format.Name = "lbl_commit_format";
            this.lbl_commit_format.Size = new System.Drawing.Size(76, 13);
            this.lbl_commit_format.TabIndex = 6;
            this.lbl_commit_format.Text = "Commit format:";
            // 
            // lbl_a_path
            // 
            this.lbl_a_path.AutoSize = true;
            this.lbl_a_path.Location = new System.Drawing.Point(6, 28);
            this.lbl_a_path.Name = "lbl_a_path";
            this.lbl_a_path.Size = new System.Drawing.Size(73, 13);
            this.lbl_a_path.TabIndex = 0;
            this.lbl_a_path.Text = "A sources file:";
            // 
            // txt_a_path
            // 
            this.txt_a_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_a_path.Location = new System.Drawing.Point(9, 57);
            this.txt_a_path.Name = "txt_a_path";
            this.txt_a_path.Size = new System.Drawing.Size(894, 20);
            this.txt_a_path.TabIndex = 1;
            // 
            // btn_browse_b_path
            // 
            this.btn_browse_b_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_b_path.Location = new System.Drawing.Point(918, 122);
            this.btn_browse_b_path.Name = "btn_browse_b_path";
            this.btn_browse_b_path.Size = new System.Drawing.Size(75, 20);
            this.btn_browse_b_path.TabIndex = 5;
            this.btn_browse_b_path.Text = "...";
            this.btn_browse_b_path.UseVisualStyleBackColor = true;
            this.btn_browse_b_path.Click += new System.EventHandler(this.btn_refsource_directory_Click);
            // 
            // btn_browse_a_path
            // 
            this.btn_browse_a_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_a_path.Location = new System.Drawing.Point(918, 57);
            this.btn_browse_a_path.Name = "btn_browse_a_path";
            this.btn_browse_a_path.Size = new System.Drawing.Size(75, 20);
            this.btn_browse_a_path.TabIndex = 2;
            this.btn_browse_a_path.Text = "...";
            this.btn_browse_a_path.UseVisualStyleBackColor = true;
            this.btn_browse_a_path.Click += new System.EventHandler(this.btn_browse_sources_file_Click);
            // 
            // txt_b_path
            // 
            this.txt_b_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_b_path.Location = new System.Drawing.Point(9, 122);
            this.txt_b_path.Name = "txt_b_path";
            this.txt_b_path.Size = new System.Drawing.Size(894, 20);
            this.txt_b_path.TabIndex = 4;
            // 
            // lbl_b_path
            // 
            this.lbl_b_path.AutoSize = true;
            this.lbl_b_path.Location = new System.Drawing.Point(9, 96);
            this.lbl_b_path.Name = "lbl_b_path";
            this.lbl_b_path.Size = new System.Drawing.Size(81, 13);
            this.lbl_b_path.TabIndex = 3;
            this.lbl_b_path.Text = "B sources path:";
            // 
            // btn_begin
            // 
            this.btn_begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_begin.Location = new System.Drawing.Point(976, 670);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(75, 32);
            this.btn_begin.TabIndex = 9;
            this.btn_begin.Text = "Run";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // tbp_merge
            // 
            this.tbp_merge.Controls.Add(this.split_merge);
            this.tbp_merge.Location = new System.Drawing.Point(4, 22);
            this.tbp_merge.Name = "tbp_merge";
            this.tbp_merge.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_merge.Size = new System.Drawing.Size(1058, 723);
            this.tbp_merge.TabIndex = 1;
            this.tbp_merge.Text = "Merge";
            this.tbp_merge.UseVisualStyleBackColor = true;
            // 
            // split_merge
            // 
            this.split_merge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_merge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_merge.Location = new System.Drawing.Point(3, 3);
            this.split_merge.Name = "split_merge";
            this.split_merge.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_merge.Panel1
            // 
            this.split_merge.Panel1.Controls.Add(this.split_spl);
            // 
            // split_merge.Panel2
            // 
            this.split_merge.Panel2.Controls.Add(this.split_diff);
            this.split_merge.Size = new System.Drawing.Size(1052, 717);
            this.split_merge.SplitterDistance = 350;
            this.split_merge.TabIndex = 0;
            // 
            // split_spl
            // 
            this.split_spl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_spl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_spl.Location = new System.Drawing.Point(0, 0);
            this.split_spl.Name = "split_spl";
            // 
            // split_spl.Panel1
            // 
            this.split_spl.Panel1.Controls.Add(this.btn_sources_file_reload);
            this.split_spl.Panel1.Controls.Add(this.btn_browse_to_sources_file);
            this.split_spl.Panel1.Controls.Add(this.txt_sources_file);
            this.split_spl.Panel1.Controls.Add(this.lbl_sources_file_path);
            this.split_spl.Panel1.Controls.Add(this.lbl_sources_file);
            // 
            // split_spl.Panel2
            // 
            this.split_spl.Panel2.Controls.Add(this.rd_review);
            this.split_spl.Panel2.Controls.Add(this.rd_rejected);
            this.split_spl.Panel2.Controls.Add(this.rd_merged);
            this.split_spl.Panel2.Controls.Add(this.rd_dft);
            this.split_spl.Panel2.Controls.Add(this.btn_save_state);
            this.split_spl.Panel2.Controls.Add(this.btn_load_state);
            this.split_spl.Panel2.Controls.Add(this.lbl_matches);
            this.split_spl.Panel2.Controls.Add(this.lst_matches);
            this.split_spl.Size = new System.Drawing.Size(1052, 350);
            this.split_spl.SplitterDistance = 492;
            this.split_spl.TabIndex = 0;
            // 
            // btn_sources_file_reload
            // 
            this.btn_sources_file_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sources_file_reload.Location = new System.Drawing.Point(396, 5);
            this.btn_sources_file_reload.Name = "btn_sources_file_reload";
            this.btn_sources_file_reload.Size = new System.Drawing.Size(34, 26);
            this.btn_sources_file_reload.TabIndex = 8;
            this.btn_sources_file_reload.Text = "↺";
            this.btn_sources_file_reload.UseVisualStyleBackColor = true;
            this.btn_sources_file_reload.Click += new System.EventHandler(this.btn_sources_file_reload_Click);
            // 
            // btn_browse_to_sources_file
            // 
            this.btn_browse_to_sources_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_to_sources_file.Location = new System.Drawing.Point(447, 5);
            this.btn_browse_to_sources_file.Name = "btn_browse_to_sources_file";
            this.btn_browse_to_sources_file.Size = new System.Drawing.Size(33, 26);
            this.btn_browse_to_sources_file.TabIndex = 7;
            this.btn_browse_to_sources_file.Text = "📁";
            this.btn_browse_to_sources_file.UseVisualStyleBackColor = true;
            this.btn_browse_to_sources_file.Click += new System.EventHandler(this.btn_browse_to_sources_file_Click);
            // 
            // txt_sources_file
            // 
            this.txt_sources_file.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sources_file.Location = new System.Drawing.Point(8, 37);
            this.txt_sources_file.Name = "txt_sources_file";
            this.txt_sources_file.ReadOnly = true;
            this.txt_sources_file.Size = new System.Drawing.Size(477, 307);
            this.txt_sources_file.TabIndex = 6;
            // 
            // lbl_sources_file_path
            // 
            this.lbl_sources_file_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sources_file_path.Location = new System.Drawing.Point(84, 9);
            this.lbl_sources_file_path.Name = "lbl_sources_file_path";
            this.lbl_sources_file_path.ReadOnly = true;
            this.lbl_sources_file_path.Size = new System.Drawing.Size(306, 20);
            this.lbl_sources_file_path.TabIndex = 5;
            this.lbl_sources_file_path.Text = "%path%";
            // 
            // lbl_sources_file
            // 
            this.lbl_sources_file.AutoSize = true;
            this.lbl_sources_file.Location = new System.Drawing.Point(6, 12);
            this.lbl_sources_file.Name = "lbl_sources_file";
            this.lbl_sources_file.Size = new System.Drawing.Size(65, 13);
            this.lbl_sources_file.TabIndex = 4;
            this.lbl_sources_file.Text = "Sources file:";
            // 
            // rd_review
            // 
            this.rd_review.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_review.AutoSize = true;
            this.rd_review.Location = new System.Drawing.Point(212, 316);
            this.rd_review.Name = "rd_review";
            this.rd_review.Size = new System.Drawing.Size(61, 17);
            this.rd_review.TabIndex = 7;
            this.rd_review.TabStop = true;
            this.rd_review.Text = "Review";
            this.rd_review.UseVisualStyleBackColor = true;
            // 
            // rd_rejected
            // 
            this.rd_rejected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_rejected.AutoSize = true;
            this.rd_rejected.Location = new System.Drawing.Point(138, 316);
            this.rd_rejected.Name = "rd_rejected";
            this.rd_rejected.Size = new System.Drawing.Size(68, 17);
            this.rd_rejected.TabIndex = 6;
            this.rd_rejected.TabStop = true;
            this.rd_rejected.Text = "Rejected";
            this.rd_rejected.UseVisualStyleBackColor = true;
            // 
            // rd_merged
            // 
            this.rd_merged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_merged.AutoSize = true;
            this.rd_merged.Location = new System.Drawing.Point(70, 316);
            this.rd_merged.Name = "rd_merged";
            this.rd_merged.Size = new System.Drawing.Size(61, 17);
            this.rd_merged.TabIndex = 5;
            this.rd_merged.TabStop = true;
            this.rd_merged.Text = "Merged";
            this.rd_merged.UseVisualStyleBackColor = true;
            // 
            // rd_dft
            // 
            this.rd_dft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_dft.AutoSize = true;
            this.rd_dft.Location = new System.Drawing.Point(5, 316);
            this.rd_dft.Name = "rd_dft";
            this.rd_dft.Size = new System.Drawing.Size(59, 17);
            this.rd_dft.TabIndex = 4;
            this.rd_dft.TabStop = true;
            this.rd_dft.Text = "Default";
            this.rd_dft.UseVisualStyleBackColor = true;
            // 
            // btn_save_state
            // 
            this.btn_save_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_state.Location = new System.Drawing.Point(475, 7);
            this.btn_save_state.Name = "btn_save_state";
            this.btn_save_state.Size = new System.Drawing.Size(75, 23);
            this.btn_save_state.TabIndex = 3;
            this.btn_save_state.Text = "Load state";
            this.btn_save_state.UseVisualStyleBackColor = true;
            // 
            // btn_load_state
            // 
            this.btn_load_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load_state.Location = new System.Drawing.Point(394, 7);
            this.btn_load_state.Name = "btn_load_state";
            this.btn_load_state.Size = new System.Drawing.Size(75, 23);
            this.btn_load_state.TabIndex = 2;
            this.btn_load_state.Text = "Save state";
            this.btn_load_state.UseVisualStyleBackColor = true;
            // 
            // lbl_matches
            // 
            this.lbl_matches.AutoSize = true;
            this.lbl_matches.Location = new System.Drawing.Point(14, 13);
            this.lbl_matches.Name = "lbl_matches";
            this.lbl_matches.Size = new System.Drawing.Size(48, 13);
            this.lbl_matches.TabIndex = 1;
            this.lbl_matches.Text = "Matches";
            // 
            // lst_matches
            // 
            this.lst_matches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_matches.FormattingEnabled = true;
            this.lst_matches.Location = new System.Drawing.Point(5, 37);
            this.lst_matches.Name = "lst_matches";
            this.lst_matches.Size = new System.Drawing.Size(544, 274);
            this.lst_matches.TabIndex = 0;
            // 
            // split_diff
            // 
            this.split_diff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_diff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_diff.Location = new System.Drawing.Point(0, 0);
            this.split_diff.Name = "split_diff";
            // 
            // split_diff.Panel1
            // 
            this.split_diff.Panel1.Controls.Add(this.btn_file_a_reload);
            this.split_diff.Panel1.Controls.Add(this.btn_browse_to_file_a);
            this.split_diff.Panel1.Controls.Add(this.txt_file_a);
            this.split_diff.Panel1.Controls.Add(this.lbl_file_a_path);
            this.split_diff.Panel1.Controls.Add(this.lbl_file_a);
            // 
            // split_diff.Panel2
            // 
            this.split_diff.Panel2.Controls.Add(this.btn_file_b_reload);
            this.split_diff.Panel2.Controls.Add(this.btn_browse_to_file_b);
            this.split_diff.Panel2.Controls.Add(this.txt_file_b);
            this.split_diff.Panel2.Controls.Add(this.lbl_file_b_path);
            this.split_diff.Panel2.Controls.Add(this.lbl_file_b);
            this.split_diff.Size = new System.Drawing.Size(1052, 363);
            this.split_diff.SplitterDistance = 491;
            this.split_diff.TabIndex = 0;
            // 
            // btn_file_a_reload
            // 
            this.btn_file_a_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_file_a_reload.Location = new System.Drawing.Point(396, 4);
            this.btn_file_a_reload.Name = "btn_file_a_reload";
            this.btn_file_a_reload.Size = new System.Drawing.Size(34, 26);
            this.btn_file_a_reload.TabIndex = 9;
            this.btn_file_a_reload.Text = "↺";
            this.btn_file_a_reload.UseVisualStyleBackColor = true;
            this.btn_file_a_reload.Click += new System.EventHandler(this.btn_file_a_reload_Click);
            // 
            // btn_browse_to_file_a
            // 
            this.btn_browse_to_file_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_to_file_a.Location = new System.Drawing.Point(447, 4);
            this.btn_browse_to_file_a.Name = "btn_browse_to_file_a";
            this.btn_browse_to_file_a.Size = new System.Drawing.Size(34, 26);
            this.btn_browse_to_file_a.TabIndex = 3;
            this.btn_browse_to_file_a.Text = "📁";
            this.btn_browse_to_file_a.UseVisualStyleBackColor = true;
            this.btn_browse_to_file_a.Click += new System.EventHandler(this.btn_browse_to_file_a_Click);
            // 
            // txt_file_a
            // 
            this.txt_file_a.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_file_a.Location = new System.Drawing.Point(9, 36);
            this.txt_file_a.Name = "txt_file_a";
            this.txt_file_a.ReadOnly = true;
            this.txt_file_a.Size = new System.Drawing.Size(477, 307);
            this.txt_file_a.TabIndex = 2;
            // 
            // lbl_file_a_path
            // 
            this.lbl_file_a_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_file_a_path.Location = new System.Drawing.Point(65, 8);
            this.lbl_file_a_path.Name = "lbl_file_a_path";
            this.lbl_file_a_path.ReadOnly = true;
            this.lbl_file_a_path.Size = new System.Drawing.Size(325, 20);
            this.lbl_file_a_path.TabIndex = 1;
            this.lbl_file_a_path.Text = "%path%";
            // 
            // lbl_file_a
            // 
            this.lbl_file_a.AutoSize = true;
            this.lbl_file_a.Location = new System.Drawing.Point(7, 11);
            this.lbl_file_a.Name = "lbl_file_a";
            this.lbl_file_a.Size = new System.Drawing.Size(52, 13);
            this.lbl_file_a.TabIndex = 0;
            this.lbl_file_a.Text = "A source:";
            // 
            // btn_file_b_reload
            // 
            this.btn_file_b_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_file_b_reload.Location = new System.Drawing.Point(465, 4);
            this.btn_file_b_reload.Name = "btn_file_b_reload";
            this.btn_file_b_reload.Size = new System.Drawing.Size(34, 26);
            this.btn_file_b_reload.TabIndex = 10;
            this.btn_file_b_reload.Text = "↺";
            this.btn_file_b_reload.UseVisualStyleBackColor = true;
            this.btn_file_b_reload.Click += new System.EventHandler(this.btn_file_b_reload_Click);
            // 
            // btn_browse_to_file_b
            // 
            this.btn_browse_to_file_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_to_file_b.Location = new System.Drawing.Point(514, 4);
            this.btn_browse_to_file_b.Name = "btn_browse_to_file_b";
            this.btn_browse_to_file_b.Size = new System.Drawing.Size(34, 26);
            this.btn_browse_to_file_b.TabIndex = 6;
            this.btn_browse_to_file_b.Text = "📁";
            this.btn_browse_to_file_b.UseVisualStyleBackColor = true;
            this.btn_browse_to_file_b.Click += new System.EventHandler(this.btn_browse_to_file_b_Click);
            // 
            // txt_file_b
            // 
            this.txt_file_b.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_file_b.Location = new System.Drawing.Point(3, 36);
            this.txt_file_b.Name = "txt_file_b";
            this.txt_file_b.ReadOnly = true;
            this.txt_file_b.Size = new System.Drawing.Size(547, 307);
            this.txt_file_b.TabIndex = 5;
            // 
            // lbl_file_b_path
            // 
            this.lbl_file_b_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_file_b_path.Location = new System.Drawing.Point(61, 8);
            this.lbl_file_b_path.Name = "lbl_file_b_path";
            this.lbl_file_b_path.ReadOnly = true;
            this.lbl_file_b_path.Size = new System.Drawing.Size(398, 20);
            this.lbl_file_b_path.TabIndex = 4;
            this.lbl_file_b_path.Text = "%path%";
            // 
            // lbl_file_b
            // 
            this.lbl_file_b.AutoSize = true;
            this.lbl_file_b.Location = new System.Drawing.Point(3, 11);
            this.lbl_file_b.Name = "lbl_file_b";
            this.lbl_file_b.Size = new System.Drawing.Size(52, 13);
            this.lbl_file_b.TabIndex = 3;
            this.lbl_file_b.Text = "B source:";
            // 
            // tbp_output
            // 
            this.tbp_output.Controls.Add(this.btn_save_output);
            this.tbp_output.Controls.Add(this.txt_output);
            this.tbp_output.Location = new System.Drawing.Point(4, 22);
            this.tbp_output.Name = "tbp_output";
            this.tbp_output.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_output.Size = new System.Drawing.Size(1058, 723);
            this.tbp_output.TabIndex = 2;
            this.tbp_output.Text = "Output";
            this.tbp_output.UseVisualStyleBackColor = true;
            // 
            // btn_save_output
            // 
            this.btn_save_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_output.Location = new System.Drawing.Point(942, 671);
            this.btn_save_output.Name = "btn_save_output";
            this.btn_save_output.Size = new System.Drawing.Size(108, 23);
            this.btn_save_output.TabIndex = 1;
            this.btn_save_output.Text = "Save as...";
            this.btn_save_output.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.Location = new System.Drawing.Point(4, 7);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(1051, 657);
            this.txt_output.TabIndex = 0;
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(0, 727);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(1066, 22);
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 749);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.tbc_root);
            this.Name = "frm_main";
            this.Text = "kasthack\'s RefSource merger";
            this.tbc_root.ResumeLayout(false);
            this.tbp_settings.ResumeLayout(false);
            this.grp_new_session.ResumeLayout(false);
            this.grp_new_session.PerformLayout();
            this.tbp_merge.ResumeLayout(false);
            this.split_merge.Panel1.ResumeLayout(false);
            this.split_merge.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_merge)).EndInit();
            this.split_merge.ResumeLayout(false);
            this.split_spl.Panel1.ResumeLayout(false);
            this.split_spl.Panel1.PerformLayout();
            this.split_spl.Panel2.ResumeLayout(false);
            this.split_spl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_spl)).EndInit();
            this.split_spl.ResumeLayout(false);
            this.split_diff.Panel1.ResumeLayout(false);
            this.split_diff.Panel1.PerformLayout();
            this.split_diff.Panel2.ResumeLayout(false);
            this.split_diff.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_diff)).EndInit();
            this.split_diff.ResumeLayout(false);
            this.tbp_output.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_root;
        private System.Windows.Forms.TabPage tbp_settings;
        private System.Windows.Forms.Button btn_browse_b_path;
        private System.Windows.Forms.TextBox txt_b_path;
        private System.Windows.Forms.Label lbl_b_path;
        private System.Windows.Forms.Button btn_browse_a_path;
        private System.Windows.Forms.TextBox txt_a_path;
        private System.Windows.Forms.Label lbl_a_path;
        private System.Windows.Forms.TabPage tbp_merge;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.TabPage tbp_output;
        private gui_merger.Controls.RWScintilla txt_output;
        private System.Windows.Forms.Button btn_save_output;
        private System.Windows.Forms.SplitContainer split_merge;
        private System.Windows.Forms.SplitContainer split_spl;
        private System.Windows.Forms.Button btn_browse_to_sources_file;
        private gui_merger.Controls.RWScintilla txt_sources_file;
        private System.Windows.Forms.TextBox lbl_sources_file_path;
        private System.Windows.Forms.Label lbl_sources_file;
        private System.Windows.Forms.Label lbl_matches;
        private System.Windows.Forms.CheckedListBox lst_matches;
        private System.Windows.Forms.SplitContainer split_diff;
        private System.Windows.Forms.Button btn_browse_to_file_a;
        private gui_merger.Controls.RWScintilla txt_file_a;
        private System.Windows.Forms.TextBox lbl_file_a_path;
        private System.Windows.Forms.Label lbl_file_a;
        private System.Windows.Forms.Button btn_browse_to_file_b;
        private gui_merger.Controls.RWScintilla txt_file_b;
        private System.Windows.Forms.TextBox lbl_file_b_path;
        private System.Windows.Forms.Label lbl_file_b;
        private System.Windows.Forms.GroupBox grp_new_session;
        private System.Windows.Forms.Label lbl_commit_format;
        private System.Windows.Forms.Button btn_save_state;
        private System.Windows.Forms.Button btn_load_state;
        private System.Windows.Forms.RadioButton rd_review;
        private System.Windows.Forms.RadioButton rd_rejected;
        private System.Windows.Forms.RadioButton rd_merged;
        private System.Windows.Forms.RadioButton rd_dft;
        private gui_merger.Controls.RWScintilla txt_commit_format;
        private System.Windows.Forms.Button btn_sources_file_reload;
        private System.Windows.Forms.Button btn_file_a_reload;
        private System.Windows.Forms.Button btn_file_b_reload;
    }
}