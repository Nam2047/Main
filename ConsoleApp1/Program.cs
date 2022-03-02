using System;
/*
namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball soccer = new Ball(17, "Black", "ABC company");
            soccer.InformationOfTheBall();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
    public class Ball
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public string Madeby { get; set; }
        public Ball(int size, string color, string madeby)
        {
            Size = size;
            Color = color;
            Madeby = madeby;
        }
        public void InformationOfTheBall()
        {
            Console.WriteLine("Size: {0}cm Color: {1} Made by: {2}", Size, Color, Madeby);
        }
    }
}*/
using System.Windows.Input;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
    }
}