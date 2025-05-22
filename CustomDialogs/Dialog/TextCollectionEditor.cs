using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class TextCollectionEditor : Form {
        public ISet<string> Values { get; set; }
        public string ValueName { get; set; }

        public Func<IEnumerable<string>> AddFunction { get; set; }
        public Func<string, Image> GetIconFunction { get; set; }

        public bool DialogClosed { get; private set; } = true;

        public TextCollectionEditor(ISet<string> values, string valueName, Func<IEnumerable<string>> addFunction, Func<string, Image> getIconFunction) {
            InitializeComponent();

            Values = new HashSet<string>(values);
            ValueName = valueName;

            AddFunction = addFunction;
            GetIconFunction = getIconFunction;

            Text = ValueName;
            GridViewColumn.HeaderText = ValueName;
        }

        private void TextCollectionEditor_Load(object sender, EventArgs e) {
            LoadGridView();
        }

        private void LoadGridView() {
            GridView.Rows.Clear();

            foreach (string value in Values) {
                GridView.Rows.Add(value);
                GridView.Rows[GridView.Rows.Count - 1].DisplayImage(GridViewColumn, GetIconFunction(value), 25);
            }

            GridView.ClearSelection();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            DialogClosed = false;
            Close();
        }
        private void AddButton_Click(object sender, EventArgs e) {
            IEnumerable<string> values = AddFunction();
            Values.UnionWith(values);

            LoadGridView();
        }

        private void RemoveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow folder in GridView.SelectedRows) {
                Values.Remove((string)folder.Cells[0].Value);
            }

            LoadGridView();
        }
    }
}
