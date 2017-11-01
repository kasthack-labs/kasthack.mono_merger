//#define DBG_Q
using gui_merger.Core;
using kasthack.binding.wf;
using Microsoft.WindowsAPICodePack.Dialogs;
using ScintillaNET;
using System;
using System.Windows.Forms;

namespace gui_merger
{
    public partial class frm_main : Form
    {
        private readonly Merge model;
        private readonly MergeVM vm;

        public frm_main()
        {
            InitializeComponent();
            foreach (var v in new[] {
                txt_commit_format,
                txt_file_a,
                txt_file_b,
                txt_output
//#if !DBG_Q
                ,txt_sources_file
//#endif
            })
                SetupCodeEditor(v);

            model = new Merge();
            vm = new MergeVM(model);
            SetupBindings();
        }
        void SetupBindings()
        {
            SetupSettingsBindings();
            SetupMergeBindings();
        }
        void SetupSettingsBindings()
        {
            ClearBindings(txt_a_path, txt_b_path);
            txt_a_path.Bind(a => a.Text, vm, a => a.State.Settings.APath);
            txt_b_path.Bind(a => a.Text, vm, a => a.State.Settings.BPath);
            txt_commit_format.Bind(a => a.Text, vm, a => a.State.Settings.CommitFormat);
        }
        void SetupMergeBindings()
        {

            ClearBindings(lbl_sources_file_path, txt_sources_file, lbl_file_a_path, txt_file_a, lbl_file_b_path, txt_file_b);
            //top
            //top-right
            lbl_sources_file_path.Bind(a => a.Text, vm, a => a.State.SourcesFile.AbsolutePath);
            txt_sources_file.Bind(a => a.Text, vm, a => a.State.SourcesFile.Text);
            //bottom
            //bottom-left
            lbl_file_a_path.Bind(a => a.Text, vm, a => a.State.CurrentPair.A.AbsolutePath);
            txt_file_a.Bind(a => a.Text, vm, a => a.State.CurrentPair.A.Text);
            //bottom-right
            lbl_file_b_path.Bind(a => a.Text, vm, a => a.State.CurrentPair.B.AbsolutePath);
            txt_file_b.Bind(a => a.Text, vm, a => a.State.CurrentPair.B.Text);
        }
#region Control helpers
        void ClearBindings(params Control[] contols)
        {
            foreach (var v in contols)
                v.DataBindings.Clear();
        }
        void SetupCodeEditor(Scintilla scintilla)
        {
            var margin = scintilla.Margins[0];
            margin.Type = MarginType.Number;
            margin.Width = 16;
        }

        private void CFD(string title, bool folder, TextBox bound)
        {

            using (var fd = new CommonOpenFileDialog()
            {
                AddToMostRecentlyUsedList = true,
                AllowNonFileSystemItems = false,
                EnsurePathExists = true,
                RestoreDirectory = true,
                Multiselect = false,
                IsFolderPicker = folder,
                Title = title,
            })
                if (fd.ShowDialog() == CommonFileDialogResult.Ok)
                    bound.Text = fd.FileName;
        }
#endregion
#region Event handlers
        private void btn_browse_sources_file_Click(object sender, EventArgs e) => CFD("A sources file", false, txt_a_path);
        private void btn_refsource_directory_Click(object sender, EventArgs e) => CFD("B sources file", true, txt_b_path);
        private void btn_browse_to_file_a_Click(object sender, EventArgs e) => vm.State.CurrentPair?.A?.ShowInExplorer();
        private void btn_browse_to_file_b_Click(object sender, EventArgs e) => vm.State.CurrentPair?.B?.ShowInExplorer();
        private void btn_browse_to_sources_file_Click(object sender, EventArgs e) => vm.State?.SourcesFile?.ShowInExplorer();
        private void btn_sources_file_reload_Click(object sender, EventArgs e) => vm.State?.SourcesFile?.Reload();

        private void btn_file_a_reload_Click(object sender, EventArgs e) => vm.State?.CurrentPair?.A?.Reload();
        private void btn_file_b_reload_Click(object sender, EventArgs e) => vm.State?.CurrentPair?.B?.Reload();
        private void btn_begin_Click(object sender, EventArgs e) => vm.Merge();
#endregion

        private void tbc_root_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (tbc_root.SelectedIndex)
            //{
            //    /*
            //     * 0-settings
            //     * 1-merge
            //     * 2-output
            //     * 3-debug data[debug build only]
            //     */
            //    case 1:
            //        SetupMergeBindings(); //scintilla bug(?) workaround
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
