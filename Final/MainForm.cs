using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class MainForm : Form
    {
        Graphics g;
         public MainForm()
        {
            InitializeComponent();
        }

        ShapesCreator factory = new ShapesFactory();
        Pen myPen = new Pen(Color.Red);
        public Color newcolor;
        int x = 0, y = 0, width, height, radius;

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT files (.txt)|*.txt|All files (.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.WriteLine(txt_cmd_shp.Text);
                write.Close();
                MessageBox.Show("File has been saved successfully!");
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Browse file from specified folder";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "TXT files (.txt)|*.txt|All files (.*)|*.*";
            openFileDialog1.Filter = "DOCX files (.docx)|*.docx|All files (.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //Browse .txt file from computer             
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.                        
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                //displays the text inside the file on TextBox named as txtInput                
                txt_cmd_shp.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_cmd_shp.Text = "";
            Graphics g1 = Output_Box.CreateGraphics();
            g1.Clear(Output_Box.BackColor);
            txt_Execution_instruction.Text = "";

        }

        private void applicationGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationGuide ag = new ApplicationGuide();
            ag.MdiParent = this;
            ag.Show();
           
            
        }


        private void txt_Execution_Box_TextChanged(object sender, EventArgs e)
        {
            if (txt_Execution_instruction.Text.ToLower().Trim() == "run")
            {
                Graphics g = Output_Box.CreateGraphics();
                string command = txt_cmd_shp.Text.ToLower();
                string[] commandline = command.Split(new String[] { "\n" },
                 StringSplitOptions.RemoveEmptyEntries);

                for (int k = 0; k < commandline.Length; k++)
                {
                    string[] cmd = commandline[k].Split(' ');
                    if (cmd[0].Equals("moveto") == true)
                    {
                        Output_Box.Refresh();
                        string[] param = cmd[1].Split(',');
                        if (param.Length != 2)
                        { MessageBox.Show("Incorrect Parameter"); }
                        else
                        {
                            Int32.TryParse(param[0], out x);
                            Int32.TryParse(param[1], out y);
                            moveTo(x, y);
                        }

                    }
                    else if (cmd[0].Equals("drawto") == true)
                    {
                        string[] param = cmd[1].Split(',');
                        int x = 0, y = 0;
                        if (param.Length != 2)
                        {
                            MessageBox.Show("Incorrect Parameter");
                        }
                        else
                        {
                            Int32.TryParse(param[0], out x);
                            Int32.TryParse(param[1], out y);
                            drawTo(x, y);
                        }
                    }
                    else if (cmd[0].Equals("rectangle") == true)
                    {
                        if (cmd.Length < 2)
                        {
                            MessageBox.Show("Please input your parameter correctly !!! ");

                        }
                        else
                        {
                            string[] param = cmd[1].Split(',');
                            if (param.Length < 2)
                            {
                                MessageBox.Show("Please input your parameter correctly !!! ");

                            }
                            else
                            {
                                Int32.TryParse(param[0], out width);
                                Int32.TryParse(param[1], out height);
                                IShapes circle = factory.getShape("rectangle");
                                Rectangle r = new Rectangle();
                                r.set(Color.Black, x, y, width, height);
                                r.draw(g);


                            }
                        }
                    }

                    else if (cmd[0].Equals("circle") == true)
                    {
                        if (cmd.Length != 2) 
                        { 
                            MessageBox.Show("Incorrect Parameter");
                        }
                        else
                        {
                            if (cmd[1].Equals("radius") == true)
                            {
                                IShapes circle = factory.getShape("circle");
                                Circle c = new Circle();
                                c.set(Color.AliceBlue, x, y, radius);
                                c.draw(g);
                            }
                            else
                            {
                                Int32.TryParse(cmd[1], out radius);
                                IShapes circle = factory.getShape("circle");
                                Circle c = new Circle();
                                c.set(Color.AliceBlue, x, y, radius);
                                c.draw(g);
                            }
                        }
                    }

                    else if (cmd[0].Equals("triangle") == true)
                    {
                        string[] param = cmd[1].Split(',');
                        if (param.Length != 2)
                        {
                            MessageBox.Show("Incorrect Parameter");

                        }
                        else
                        {
                            Int32.TryParse(param[0], out width);
                            Int32.TryParse(param[1], out height);
                            IShapes circle = factory.getShape("triangle");
                            Triangle r = new Triangle();
                            r.set(Color.AliceBlue, x, y, width, height);
                            r.draw(g);
                        }
                    }

                    else if (!cmd[0].Equals(null))
                    {
                        int errorLine = k + 1;
                        MessageBox.Show("Your command is not correct at line " + errorLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                if (txt_Execution_instruction.Text.ToLower().Trim() == "clear")
                {
                    txt_cmd_shp.Clear();

                }
            }
        }

        public void moveTo(int toX, int toY)
        {
            x = toX;
            y = toY;
        }

        public void drawTo(int toX, int toY)
        {
            x = toX;
            y = toY;
        }

    }
}
