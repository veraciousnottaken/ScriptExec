using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ScriptExec.Class;

namespace ScriptExec
{
    public partial class ScriptExec : Form
    {
        private IniHelper _config;
        private string _parameters;
        private string _scriptname;

        public ScriptExec()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            var options = new Options();
            var args = Environment.GetCommandLineArgs();
            var currdir = Environment.CurrentDirectory;

            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                throw new ScriptExecException("Wrong command line arguments;");
            }

            Text += " " + options.IniFile;

            _config = new IniHelper(currdir + options.IniFile);

            var scripts = GetScripts();

            FillScriptsList(scripts);
            FillGlobal();
            ToggleButtons();
        }

        private void FillGlobal()
        {
            tbPath.Text = _config.Repo.Path;
            tbUsername.Text = _config.Repo.Username;
            tbPassword.Text = _config.Repo.Password;
        }

        private void FillScriptsList(IEnumerable<FileInfo> scripts)
        {
            foreach (var fileInfo in scripts)
            {
                var extras = _config.GetScriptExtras(fileInfo.Name);

                var lvi = new ListViewItem();

                lvi.Text = fileInfo.Name;

                var subitem = new ListViewItem.ListViewSubItem();
                subitem.Text = extras.Parameters;

                lvi.SubItems.Add(subitem);

                lvScript.Items.Add(lvi);
            }
        }

        private IEnumerable<FileInfo> GetScripts()
        {
            return _config.GetScripts();
        }

        private void cbUNCPath_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtons();
        }

        private void ToggleButtons()
        {
            cbUNCPath.Checked = tbPath.Text.StartsWith("\\\\");
            tbPassword.Enabled = tbUsername.Enabled = cbUNCPath.Checked;
            bExecScript.Enabled = lvScript.SelectedItems.Count > 0;
        }

        private void tbPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToggleButtons();
        }

        private void bExecScript_Click(object sender, EventArgs e)
        {
            ExecuteSelectedScript();
        }

        private void lvScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvScript.SelectedItems.Count > 0)
            {
                _scriptname = _config.Repo.Path + lvScript.SelectedItems[0].Text;
                _parameters = lvScript.SelectedItems[0].SubItems.Count > 0
                    ? lvScript.SelectedItems[0].SubItems[1].Text : "";

                tbScript.Text = _scriptname;
                tbParameters.Text = _parameters;
            }

            ToggleButtons();
        }

        private void tbParameters_TextChanged(object sender, EventArgs e)
        {
            _parameters = tbParameters.Text;
        }

        private void lvScript_DoubleClick(object sender, EventArgs e)
        {
            ExecuteSelectedScript();
        }

        private void ExecuteSelectedScript()
        {
            var res = Executor.RunExternalExe(_scriptname, _parameters);

            rtbResults.Text = res;
        }

        private void bSaveGlobal_Click(object sender, EventArgs e)
        {
            _config.Save();
        }
    }
}