using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text;

namespace practica1
{
    public partial class Form1 : Form
    {
        int i = 3, j = 17, s_i = 20, s_j = 20;
        public Pen redPen = new Pen(Color.Red, 3f);
        public Pen grinpen = new Pen(Color.Green, 2);
        public Pen bluepen = new Pen(Color.Blue, 3);
        public Pen goldpen = new Pen(Color.Gold, 2);
        public Pen blackpen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();

        }

        private void ôèóãğûToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ëèíèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(redPen, 246, 30, 350, 30); //ãîğèçîíòàëüíàÿ
            g.DrawLine(grinpen, 400, 24, 500, 147); //âåòèêàëüíàÿ
            g.DrawLine(bluepen, 500, 24, 24, 500); //äèîãîíàëè
            g.Dispose();

        }

        private void ïğÿìîóãîëüíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(bluepen, 246, 30, 200, 350);
            g.FillRectangle(Brushes.ForestGreen, 12, 171, 100, 150);
            g.Dispose();
        }

        private void î÷èñòèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void êâàäğàòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(grinpen, 246, 30, 200, 200);
            g.FillRectangle(Brushes.IndianRed, 446, 80, 200, 200);
            g.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void îêğóæíîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(goldpen, 246, 30, 300, 200);
            g.FillEllipse(Brushes.LightPink, 346, 130, 300, 200);
            g.Dispose();
        }

        private void êğóãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(redPen, 246, 30, 200, 200);
            g.FillEllipse(Brushes.MediumSlateBlue, 346, 130, 200, 200);
            g.Dispose();
        }

        private void òğåóãîëüíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] treygoln = { new Point(120, 40), new Point(110, 60), new Point(145, 100) };
            Graphics g = this.CreateGraphics();
            Point[] fill_treygoln = { new Point(220, 40), new Point(210, 60), new Point(245, 100) };
            g.DrawPolygon(redPen, treygoln);
            g.FillPolygon(Brushes.PaleGoldenrod, fill_treygoln);
            g.Dispose();
        }

        private void òğàïåöèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] treap = { new Point(190, 100), new Point(290, 100), new Point(100, 290), new Point(100, 190) };
            Point[] fill_trap = { new Point(290, 100), new Point(390, 100), new Point(200, 290), new Point(200, 190) };
            Graphics g = this.CreateGraphics();
            g.DrawPolygon(redPen, fill_trap);
            g.FillPolygon(Brushes.Ivory, fill_trap);
            g.Dispose();
        }

        private void øåñòèóãîëüíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] six_ugol = { new Point(287, 56), new Point(387,125), new Point(387, 190),  new Point(287, 239), new Point(197, 190), new Point (198, 125) };
            Point[] fill_six_ugol = { new Point(487, 156), new Point(587, 225), new Point(587, 290), new Point(487, 339), new Point(397, 290), new Point(398, 225) };
            Graphics g = this.CreateGraphics();
            g.DrawPolygon(redPen, six_ugol);
            g.FillPolygon(Brushes.Fuchsia, fill_six_ugol);
            g.Dispose();
        }

        private void êâàäğàòÂÊâàäğàòåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen[] kvadrat = { new Pen(Color.Red, 2), new Pen(Color.Gainsboro, 2), new Pen(Color.Green, 2), new Pen(Color.Black, 2) };
            Graphics g = this.CreateGraphics();
            int x = 100, y = 100, size = 200;
            
            for(int i = 1; i < 5; i++)
            {
                g.DrawRectangle(kvadrat[i - 1], x,y, size, size);
                x += 5;
                y += 5;
                if(i > 0) size -= 10;
            }
            g.Dispose();
        }

        private void ñíåãîâèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //Òåëî
            g.FillEllipse(Brushes.LightBlue, 246, 130, 80, 80); 
            g.FillEllipse(Brushes.LightBlue, 246, 210, 80, 80);
            g.FillEllipse(Brushes.LightBlue, 246, 290, 80, 80);

            //Ãëàçà
            g.FillEllipse(Brushes.Black, 260, 150, 10, 10);
            g.FillEllipse(Brushes.Black, 280, 150, 10, 10);

            //Íîñ
            Point[] kolpac = { new Point(270, 165), new Point(276, 165), new Point(255, 185) };
            g.FillPolygon(Brushes.Orange, kolpac);

            //êîëïàê
            g.FillRectangle(Brushes.Red, 260, 85, 50, 60);

            //åëêà
            Point[] treygoln_1 = { new Point(350, 370), new Point(450, 370), new Point(400, 250) };
            Point[] treygoln_2 = { new Point(350, 250), new Point(450, 250), new Point(400, 170) };
            Point[] treygoln_3 = { new Point(350, 170), new Point(450, 170), new Point(400, 90) };
            g.FillPolygon(Brushes.Green, treygoln_1);
            g.FillPolygon(Brushes.Green, treygoln_2);
            g.FillPolygon(Brushes.Green, treygoln_3);
            g.Dispose();

        }

        private void ãğàôèêÇàäàíèå3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.DrawLine(blackpen, 827, 30, 827, 1151); //ãîğèçîíòàëüíàÿ
            //g.DrawLine(blackpen, 0, 575, 1655, 575); //Âåğòèêàëüíàÿ

            Point[] point = new Point[500];

            for(int i = 0; i < point.Length; i++)
            {
                //double y = Math.Pow((double)i, 3);
                double x = Math.Pow(i, 1 / 3);
                point[i] = new Point((int)x, i);
            }

            g.DrawLines(redPen, point);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void ñèíóñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Point[] points = new Point[1000];
            for(int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / 10 * 100) + 200));
            } 
            g.DrawLines(redPen, points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void ëåòÿùèéÊğóãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            
            i = i + s_i;
            j = j + s_j;

            if (i > 1490 || i < 0) s_i = -s_i; //x
            if (j > 978|| j < 15) s_j = -s_j; //y
            


            g.FillEllipse(Brushes.Khaki, i, j, 50, 50);// ğèñóåì ıëëèïñ                
            Thread.Sleep(100);
            g.Clear(Color.White); //ñòèğàåì íàğèñîâàííûé ıëëèïñ 

            g.Dispose();





        }

    }
}
