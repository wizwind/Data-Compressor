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
using System.IO.Compression;
using System.Threading;


namespace finalsoftwaremini
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string g = string.Format(textBox1.Text);
            Int64 fileSizeInBytes = new FileInfo(g).Length;
            string a = fileSizeInBytes.ToString();
            label3.Text = a;


            string k = string.Format(textBox1.Text);

            FileInfo fileToBeDeflateZipped = new FileInfo(k);
            FileInfo deflateZipFileName = new FileInfo(string.Concat(fileToBeDeflateZipped.FullName, ".cmp"));

            using (FileStream fileToBeZippedAsStream = fileToBeDeflateZipped.OpenRead())
            {
                using (FileStream deflateZipTargetAsStream = deflateZipFileName.Create())
                {
                    using (DeflateStream deflateZipStream = new DeflateStream(deflateZipTargetAsStream, CompressionMode.Compress))
                    {
                        try
                        {
                            fileToBeZippedAsStream.CopyTo(deflateZipStream);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pk=textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string m = string.Format(textBox1.Text);
            FileInfo fileToBeDeflateZipped = new FileInfo(m);
            FileInfo deflateZipFileName = new FileInfo(string.Concat(fileToBeDeflateZipped.FullName, ".cmp"));
            using (FileStream fileToDecompressAsStream = deflateZipFileName.OpenRead())
            {
                string g = string.Format(textBox2.Text);

                string decompressedFileName = g;
                using (FileStream decompressedStream = File.Create(decompressedFileName))
                {
                    using (DeflateStream decompressionStream = new DeflateStream(fileToDecompressAsStream, CompressionMode.Decompress))
                    {
                        try
                        {
                            decompressionStream.CopyTo(decompressedStream);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    string gqa = string.Format(textBox1.Text);
                    Int64 fileSizeInBytes = new FileInfo(gqa).Length;
                    string aqa = fileSizeInBytes.ToString();
                    label4.Text = aqa;
                }
            }
            string gq = string.Format(textBox1.Text + ".cmp");

            Int64 fileSizeInByte = new FileInfo(gq).Length;
            string aq = fileSizeInByte.ToString();
            label5.Text = aq;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string m = string.Format(textBox1.Text);
            //string startPath = m;
            //string w = string.Format(textBox2.Text);
            //string zipPath = w;
            //string extractPath = @"C:\Users\user pc\Desktop\opiu";

            //System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
            //System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        

     
        private void button1_Click_3(object sender, EventArgs e)
        {

           


            string zipPath = textBox4.Text;
            

            string startPath = textBox3.Text;
        
            string extractPath = textBox5.Text;

            ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, true);

            ZipFile.ExtractToDirectory(zipPath, extractPath);

          //  string gq = string.Format(textBox1.Text + ".cmp");


         

            


            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            string gq = string.Format(textBox4.Text);
            Int64 fileSizeInByte = new FileInfo(gq).Length;
            string aq = fileSizeInByte.ToString();
            label7.Text = aq;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
       
          

        }
    }

    






