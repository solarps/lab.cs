using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab.cs
{
    public partial class Form1 : Form
    {
        public int n, m;
        public int l = 0;
        //Triangle triangle;
        Triangle[] triangle;
        Equilateral[] equilaterals;
        Equilateral equilateral;
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }
        public Form1()
        {
            InitializeComponent();
        }
        // сохранение файла
        void BtnSave2_Click(object sender, EventArgs e)
        {
            if (M != 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Word Documents| *.doc|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                //// получаем выбранный файл
                //if (triangle.Save(saveFileDialog1.FileName) == true)
                //    MessageBox.Show("Файл сохранен");
                //else
                //    MessageBox.Show("Сохранение не удалось");
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                    {
                        sw.Write("Equilateral triangles:\n");
                        sw.Write(OutM.Text);
                    }
                }
                //System.IO.File.WriteAllText(filename, OutM.Text);
                //System.IO.File.WriteAllText(filename, OutN.Text);
                MessageBox.Show("Файл сохранен");
            }
            else MessageBox.Show("Введите кол-во треугольников");
        } 
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            OutN.Text = ""; 
            OutM.Text = "";
            try
            {
                N = Convert.ToInt32(InputN.Text);
                M = Convert.ToInt32(InputM.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            

            triangle = new Triangle[N];
            int seed = 0;
            for (int i = 0; i < n; i++)
            {
                do
                {
                    triangle[i] = new Triangle(seed++);
                    triangle[i].SideLength();
                    triangle[i].GetAngles();
                    triangle[i].GetPerimeter();
                    triangle[i].GetSquare();
                } while (!triangle[i].IsExists());
                OutN.Text += "NUMBER: " + (i + 1)+"\n";
                //Console.WriteLine("NUMBER: " + (i + 1));
                OutN.Text += triangle[i].PrintData();
                OutN.Text += "----------------------------\n";
            }
            if (N != 0) {
                OutN.Text += "Equal triangles: \n";
                int q = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        bool isEqual = true;
                        for (int k = 0; k < 3; k++)
                        {
                            if (triangle[i].side[k] != triangle[j].side[k])
                            {
                                isEqual = false;
                                break;
                            }
                        }
                        if (isEqual)
                        {
                            q++;
                            OutN.Text += $"{i + 1} {j + 1}";
                        }
                    }
                }
                if (q == 0) OutN.Text += "No equal triangles\n";
            }
                

            equilaterals = new Equilateral[m];

            for (int i = 0; i < m; i++)
            {
                do
                {
                    equilaterals[i] = new Equilateral(seed++);
                    equilaterals[i].SideLength();
                    equilaterals[i].GetAngles();
                    equilaterals[i].GetPerimeter();
                    equilaterals[i].GetSquare();
                } while (!equilaterals[i].IsEqualSide() || !equilaterals[i].IsExists());
                OutM.Text += "NUMBER: " + (i + 1)+"\n";
                OutM.Text += equilaterals[i].PrintData(); 
                OutM.Text += $"Median =  {equilaterals[i].GetMed():N2}\n";
                OutM.Text += "----------------------------\n";
            }
            if (m != 0)
            {
                double min = 1000000000;
                OutM.Text += "Smaller median triangle: ";
                for (int i = 0; i < m; i++)
                {
                    if (equilaterals[i].GetMed() < min)
                    {
                        min = equilaterals[i].GetMed();
                        l = i;
                    }
                }
                equilateral = new Equilateral();
                equilateral = equilaterals[l];
                OutM.Text += "NUMBER: " + (l + 1)+"\n";
                OutM.Text += equilaterals[l].PrintData();
                OutM.Text += $"Median =  { equilaterals[l].GetMed():N2}\n"; 
                OutM.Text += "----------------------------\n";
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputN_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Word Documents| *.doc|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            //файловый поток
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            //бинарный  считователь
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

            //инициализируем массив кол-вом значенний 
            N = br.ReadInt32();
            M = br.ReadInt32();
            
            triangle = new Triangle[N];
            for (int i = 0; i < N; i++)
            {
                //Считываем значения с файла
                triangle[i] = new Triangle();
                triangle[i] = triangle[i].Read(br);
            }
            equilaterals = new Equilateral[M];
            for (int i = 0; i < M; i++)
            {
                //Считываем значения с файла
                equilaterals[i] = new Equilateral();
                equilaterals[i] = equilaterals[i].Read(br);
            }
            Show();

            if (M != 0) {
                equilateral = new Equilateral();
                equilateral = equilateral.Read(br);
                OutM.Text += equilateral.PrintData();
            }
            br.Close();
            fs.Close();

            MessageBox.Show("Файл открыт"); 
        }
        private void BtnSave1_Click(object sender, EventArgs e)
        {
            if (N != 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Word Documents| *.doc|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                //файловый поток
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                //бинарный записователь 
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                Write(bw);
                bw.Close();
                fs.Close();
                MessageBox.Show("Файл сохранен");
                //// сохраняем текст в файл
                //if (filename != "")
                //{
                //    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                //    {
                //        sw.Write("Triangles:\n");
                //        sw.Write(OutN.Text);

                //    }
                //}
            }
            else MessageBox.Show("Введите кол-во треугольников");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(N);
            bw.Write(M);
            for (int i = 0; i < N; i++)
            {
                triangle[i].Write(bw);
            }
            for (int i = 0; i < M; i++)
            {
                equilaterals[i].Write(bw);
            }
            if (M!= 0)
            {
                equilateral.Write(bw);
            }
        }
        public void Show()
        {
            OutN.Text = "";
            OutM.Text = "";
            for (int i = 0; i < N; i++)
            {
                OutN.Text += "NUMBER: " + (i + 1) + "\n";
                //Console.WriteLine("NUMBER: " + (i + 1));
                OutN.Text += triangle[i].PrintData();
                OutN.Text += "----------------------------\n";
            }
            for (int i = 0; i < M; i++)
            {
                OutM.Text += "NUMBER: " + (i + 1) + "\n";
                OutM.Text += equilaterals[i].PrintData();
                OutM.Text += $"Median =  { equilaterals[i].GetMed():N2}\n";
                OutM.Text += "----------------------------\n";
            }
        }
    }
}
