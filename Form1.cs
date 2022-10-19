using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tablet
{
    public partial class Spreadsheet : Form
    {
        
        
        Data data;
        const int st = 100;
        int columns = 0;
        int rows = 0;
        string currentFileName = " ";
        public class Parser
        {
            const int tokens = 26;
            private enum Types { NONE, DELIMITER, VARIABLE, NUMBER };
            private string expressions;
            private int expressionIndex;
            private string currentToken;
            private Types TokenType;
            private double[] variables = new double[tokens];
            public string stringError = "";
            public Parser() { }
            /*
            public double ExpressionStart(string expressionString)
            {
                double result;
                expressions = expressionString;
                int lexcems = expressionString.Length;
                if (expressions[lexcems - 1].Equals('+') ||
                    expressions[lexcems - 1].Equals('-') ||
                    expressions[lexcems - 1].Equals('*') ||
                    expressions[lexcems - 1].Equals('/') ||
                    expressions[lexcems - 1].Equals('%') ||
                    expressions[lexcems - 1].Equals('+') ||
                    expressions[lexcems - 1].Equals('+') ||
                    expressions[lexcems - 1].Equals('+') ||
                    expressions[lexcems - 1].Equals('+') ||
                    expressions[lexcems - 1].Equals('+') ||
                    expressions[lexcems - 1].Equals('+'))
                {
                    MessageBox.Show("Last token should be an expression");
                    stringError = "Last token should be an expression";
                }
                expressionIndex = 0;
               
            }
            */


        }
        public Spreadsheet()
        {
            InitializeComponent();
            SetRowNum(dataGridView);

        }
        private void initializeTABLE()
        {
            columns = 5;
            rows = 10;
            string temp = null;
            char c = 'A';
            for (int i = 0; i < columns; i++)
            {
                temp += c;
                dataGridView.Columns.Add(Name, temp);
                c++;
                temp = null;
            }
        }
        private void save()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFileName = this.openFileDialog1.FileName;
                //data.SaveToFile(FileDialog1.FileName);
                this.Text = currentFileName + " -Excel";

            }
        }
        
       private void add_Row()
        {
            dataGridView.Rows.Add();
            SetRowNum(dataGridView);

        }

        private string findColumName(int index)
        {
            string result = "";
            int i = 0;
            if (index % 26 == 0) i++;
            for (; i < (int)index / 26; i++)
            {
                result += "A";
            }

            return result + (index % 26 == 0 ? "Z" : (char)(index % 26 + 64));

        }

        private void openAnotheForm()
        {
            Form3 helpForm = new Form3();
            helpForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //ФУНКЦІЯ ДЛЯ ВИДАЛЕННЯ РЯДКІВ
            if (dataGridView.RowCount <= 1)
            {
                MessageBox.Show(
                    "You're not allowed to delete a row",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete a row?",
                    "Attention!",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
                    rows--;
                }
                    

            }
            
            /*
            
            
                    
                        int row = dataGridView.RowCount - 1;
                        for (int i = 0; i < dataGridView.ColumnCount; i++)
                        {
                            string cellName = (char)(i + 65) + (row + 1).ToString();

                        }
                        dataGridView.Rows.RemoveAt(row);
                        dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
                         rows--;
                    
                     
            }
            */
        }


        private void add_Column()
        {
            int ColumCount = dataGridView.ColumnCount;
            string newColumnName = findColumName(ColumCount + 1);
            dataGridView.Columns.Add(newColumnName, newColumnName);
        }
        private void makeNotes()
        {
            Notes notes = new Notes();
            notes.ShowDialog();
        }
       
        private void deleteColumn()
        {
            //функція для видалення стовпчиків

            if (dataGridView.ColumnCount <= 1)
            {
                MessageBox.Show("You're not allowed to delete a column",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a column?",
                    "Attention!",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
                    columns--;
                }
            }

        }
            private void addColumnStrip_Click(object sender, EventArgs e)
            {
            add_Column();
            }

            private void exit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?",
                   "Attention!",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
            exit();
            }
            private void SetRowNum(DataGridView dataGridView)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_Row();
        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           deleteColumn();
        }
        
        private void SaveFile(string path)
        {
            string currentPath = " ";
           

        }
        private void open()
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            open();

        }

        //magic buttons 

        private void Form1_Load(object sender, EventArgs e)
        {

            initializeTABLE();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_Row();

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = new DataGridView();

        }

        private void aboutStrip_Click(object sender, EventArgs e)
        {
            openAbout();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //функція для видалення стовпчиків

            deleteColumn();
        }
        private void helpStrip_Click(object sender, EventArgs e)
        {
            openAnotheForm();

        }
        private void addColumn_Click(object sender, EventArgs e)
        {
            add_Column();
        }

        private void makeNotesStrip_Click(object sender, EventArgs e)
        {
            makeNotes();

        }

        private void openAbout()
        {
            Form2 aboutForm = new Form2();
            aboutForm.ShowDialog();

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        class Data
        {
            private DataGridView dataGridView;
        }
    }
    } 
