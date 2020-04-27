using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ASMLight
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            MessageBox.Show(e.TabPageIndex.ToString());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Select highlight colors from user settings
            textCode.CommentColor = (Color)ASMLight.Properties.Settings.Default["comment_color"];
        }

        private void newProject(object sender, EventArgs e)
        {

        }

        private void openProject(object sender, EventArgs e)
        {

        }

        private void saveProject(object sender, EventArgs e)
        {

        }

        private void saveProjectAs(object sender, EventArgs e)
        {

        }

        private void exportProject(object sender, EventArgs e)
        {

        }

        private void cut(object sender, EventArgs e)
        {
            textCode.Cut();
        }

        private void copy(object sender, EventArgs e)
        {
            textCode.Copy();
        }

        private void paste(object sender, EventArgs e)
        {
            textCode.Paste();
        }

        private void undo(object sender, EventArgs e)
        {
            textCode.Undo();
        }

        private void redo(object sender, EventArgs e)
        {
            textCode.Redo();
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            int index = textCode.Find(textFind.Text, textCode.SelectionStart, RichTextBoxFinds.None);

            if (index != -1)
                lblStop.Visible = false;
            else if (textFind.Text == "")
                lblStop.Visible = false;
            else
                lblStop.Visible = true;

            updateSearchButtons(index);
        }

        private void textFind_Leave(object sender, EventArgs e)
        {
            if (textFind.Text != "")
            {
                textFind.AutoCompleteCustomSource.Add(textFind.Text);
                textFind.Text = "";
            }
        }

        private void btnFindForward_Click(object sender, EventArgs e)
        {
            updateSearchButtons(-1);
            textCode.Find(textFind.Text, textCode.SelectionStart + textCode.SelectionLength,RichTextBoxFinds.None);
        }

        private void btnFindBackward_Click(object sender, EventArgs e)
        {
            updateSearchButtons(-1);
            textCode.Find(textFind.Text,0,textCode.SelectionStart, RichTextBoxFinds.Reverse);
        }

        private void updateSearchButtons(int index)
        {
            if (index == -1)
            {
                index = textCode.Text.IndexOf(textFind.Text, textCode.SelectionStart);
            }

            if (textCode.Text != "")
                if (textCode.Text.IndexOf(textFind.Text, 0, textCode.SelectionStart) != -1)
                    btnFindBackward.Enabled = true;
                else
                    btnFindBackward.Enabled = false;

            if (textCode.Text != "")
                if (textCode.Text.IndexOf(textFind.Text, index + textFind.Text.Length) != -1)
                    btnFindForward.Enabled = true;
                else
                    btnFindForward.Enabled = false;
        }

        private void delete(object sender, EventArgs e)
        {
            textCode.SelectedText = "";
        }

        private void selectAll(object sender, EventArgs e)
        {
            textCode.SelectAll();
        }
    }
}