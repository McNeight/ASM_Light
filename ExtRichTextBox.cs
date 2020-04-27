using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace System.Windows.Forms
{
    class ExtRichTextBox:RichTextBox
    {
        Color commentColor = Color.LimeGreen;
        bool assemblyHighlight = true;
        bool change = false;

        public Color CommentColor
        {
            get
            {
                return commentColor;
            }
            set
            {
                commentColor = value;
            }
        }

        public bool AssemblyHighlight
        {
            get
            {
                return assemblyHighlight;
            }
            set
            {
                assemblyHighlight = value;
            }
        }
       
        /// <summary>
        /// Syntax highlight for NASM (Currently)
        /// </summary>
        private void syntaxHighlight()
        {
            change = false;
            int selectionStart = this.SelectionStart;
            int selectionLenght = this.SelectionLength;

            string start = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1030{\\fonttbl{\\f0\\fmodern\\fprq1\\fcharset0 Lucida Console;}}\r\n{\\colortbl ;\\red128\\green128\\blue0;\\red0\\green0\\blue255;}\\viewkind4\\uc1\\pard\\fs20";
            string end = "}";
            string content = "";

            foreach (string line in this.Lines)
            {
                content += parseLine(line) + "\\par\r\n";
            }

            this.Rtf = start + content + end;

            this.Select(selectionStart, selectionLenght);
        }

        /// <summary>
        /// Parse a single line
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string parseLine(string text)
        {
            string current = "";
            bool colorChanged = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ';')
                {
                    current += "\\cf1 ";
                    colorChanged = true;
                }

                current += text[i];
            }

            if (colorChanged)
                current += "\\cf0 ";

            return current;
        }

        /*private void syntaxHighlight()
        {
            int current = 0;
            int selectionStart = this.SelectionStart;
            int selectionLenght = this.SelectionLength;

            this.SelectAll();
            this.SelectionFont = new Font(this.Font, FontStyle.Regular);
            this.SelectionColor = Color.Black;

            foreach (string line in this.Lines)
            {
                parseLine(current, line);

                current += line.Length+1;
            }

            this.Select(selectionStart, selectionLenght);
        }

        private void parseLine(int start, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ';')
                    highlightComment(start + i + 1, text);
            }
        }

        private void parseSpecificLine(int start, string text)
        {
            this.Select(start, text.Length + 1);
            this.SelectionColor = Color.Black;
            this.SelectionFont = new Font(this.Font, FontStyle.Regular);

            parseLine(start, text);
        }

        private void highlightCommand(int start, string text)
        {
            //TODO: Highlight command
        }

        private void highlightComment(int start, string text)
        {
            this.Select(start, text.Length - start);
            this.SelectionColor = commentColor;
        }

        static public bool isValidString(string s, string vChars)
        {
            bool r = true;

            foreach (char c in s)
            {
                foreach (char u in vChars)
                {
                    if (u == c)
                        r = false;
                }
            }

            return !r;
        }
         
        protected override void OnTextChanged(EventArgs e)
        {
            if (assemblyHighlight)
                syntaxHighlight();
        }*/

        protected override void OnKeyDown(KeyEventArgs e)
        {
            change = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (assemblyHighlight && change)
                syntaxHighlight();
        }
    }
}
