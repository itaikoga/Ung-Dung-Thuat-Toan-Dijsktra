using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Location> Locations = new List<Location>();
        SetUpGraph g = new SetUpGraph();
        private void Form1_Load(object creator, EventArgs e) //Hàm gọi tên các tỉnh ứng với các điểm tương ứng vào tọa độ
        {
            Location binhPhuoc = new Location("Bình Phước", "A", 541, 65);
            Location saiGon = new Location("Sài Gòn", "B", 502, 164);
            Location tayNinh = new Location("Tây Ninh", "C", 431, 105);
            Location vungTau = new Location("Vũng Tàu", "D", 590, 198);
            Location tienGiang = new Location("Tiền Giang", "E", 432, 212);
            Location anGiang = new Location("An Giang", "F", 296, 210);
            Location hauGiang = new Location("Hậu Giang", "G", 348, 286);
            Location traVinh = new Location("Trà Vinh", "H", 462, 286);
            Location kienGiang = new Location("Kiên Giang", "I", 290, 286);
            Location caMau = new Location("Cà Mau", "K", 260, 345);
            Locations.Add(binhPhuoc);
            Locations.Add(saiGon);
            Locations.Add(tayNinh);
            Locations.Add(vungTau);
            Locations.Add(tienGiang);
            Locations.Add(anGiang);
            Locations.Add(hauGiang);
            Locations.Add(traVinh);
            Locations.Add(kienGiang);
            Locations.Add(caMau);
            //Hàm thêm các thông tin vào input : cbDiemDi và CbDiemDen
            cbDiemdi.Items.Add("Bình Phước");
            cbDiemdi.Items.Add("Sài Gòn");
            cbDiemdi.Items.Add("Tây Ninh");
            cbDiemdi.Items.Add("Vũng Tàu");
            cbDiemdi.Items.Add("Tiền Giang");
            cbDiemdi.Items.Add("An Giang");
            cbDiemdi.Items.Add("Hậu Giang");
            cbDiemdi.Items.Add("Trà Vinh");
            cbDiemdi.Items.Add("Kiên Giang");
            cbDiemdi.Items.Add("Cà Mau");
            cbDiemden.Items.Add("Bình Phước");
            cbDiemden.Items.Add("Sài Gòn");
            cbDiemden.Items.Add("Tây Ninh");
            cbDiemden.Items.Add("Vũng Tàu");
            cbDiemden.Items.Add("Tiền Giang");
            cbDiemden.Items.Add("An Giang");
            cbDiemden.Items.Add("Hậu Giang");
            cbDiemden.Items.Add("Trà Vinh");
            cbDiemden.Items.Add("Kiên Giang");
            cbDiemden.Items.Add("Cà Mau");
            //Hàm in độ dài các tuyến đường vừa được vẽ
            Graphics graph = BanDoPhiaNam.CreateGraphics();
            for (int i = 0; i < Locations.Count; i++)
            {
                lvListProvinces.Items.Add(Locations[i].getPointName());
                lvListProvinces.Items[i].SubItems.Add(Locations[i].getName());
                g.listPoint.Add(Locations[i].getPoint());
                g.InsertVertex(Locations[i].getName());
            }
            g.InsertEdge("Tây Ninh", "Bình Phước", 111);
            g.InsertEdge("Vũng Tàu", "Bình Phước", 182);
            g.InsertEdge("Sài Gòn", "Bình Phước", 124);
            g.InsertEdge("Vũng Tàu", "Sài Gòn", 98);
            g.InsertEdge("Tiền Giang", "Sài Gòn", 72);
            g.InsertEdge("An Giang", "Sài Gòn", 235);
            g.InsertEdge("Tây Ninh", "Sài Gòn", 92);
            g.InsertEdge("Trà Vinh", "Sài Gòn", 125);
            g.InsertEdge("Trà Vinh", "Cà Mau", 195);
            g.InsertEdge("Trà Vinh", "Hậu Giang", 124);
            g.InsertEdge("Tiền Giang", "An Giang", 174);
            g.InsertEdge("Trà Vinh", "Tiền Giang", 68);
            g.InsertEdge("An Giang", "Trà Vinh", 187);
            g.InsertEdge("Hậu Giang", "Cà Mau", 130);
            g.InsertEdge("Cà Mau", "Kiên Giang", 106);
            g.InsertEdge("An Giang", "Hậu Giang", 146);
            g.InsertEdge("An Giang", "Kiên Giang", 96);
        }
        //Hàm vẽ lại bản đồ
        private void southMap_Paint(object creator, PaintEventArgs e)
        {
            Graphics graph = BanDoPhiaNam.CreateGraphics();
            for (int i = 0; i < Locations.Count; i++)
            {
                SolidBrush brush = new SolidBrush(Color.DarkSlateGray);
                Brush pointName = new SolidBrush(Color.BlueViolet);
                graph.FillEllipse(brush, Locations[i].getPoint().X - 3, Locations[i].getPoint().Y - 2, 18, 18);
                graph.DrawString(Locations[i].getPointName(), new Font("Times New Roman", 8), pointName, Locations[i].getPoint().X, Locations[i].getPoint().Y);
            }
            DrawLine();
        }

        private void DrawLine() // Hàm vẽ các điểm tương ứng các tỉnh và nối các điểm thành 
                                //các tuyến đường có thể đi được
        {
            DrawLine("Tây Ninh", "Bình Phước");
            DrawLine("Vũng Tàu", "Bình Phước");
            DrawLine("Sài Gòn", "Bình Phước");
            DrawLine("Vũng Tàu", "Sài Gòn");
            DrawLine("Tiền Giang", "Sài Gòn");
            DrawLine("An Giang", "Sài Gòn");
            DrawLine("Tây Ninh", "Sài Gòn");
            DrawLine("Trà Vinh", "Sài Gòn");
            DrawLine("Trà Vinh", "Cà Mau");
            DrawLine("Trà Vinh", "Hậu Giang");
            DrawLine("Tiền Giang", "An Giang");
            DrawLine("Trà Vinh", "Tiền Giang");
            DrawLine("An Giang", "Trà Vinh");
            DrawLine("Hậu Giang", "Cà Mau");
            DrawLine("Cà Mau", "Kiên Giang");
            DrawLine("An Giang", "Hậu Giang");
            DrawLine("An Giang", "Kiên Giang");
        }
        private void DrawLine(string a, string b)
        {
            Graphics graph = BanDoPhiaNam.CreateGraphics();
            int x = g.GetIndex(a);
            int y = g.GetIndex(b);
            Pen p = new Pen(Color.Black, 2);
            Point point1 = new Point(g.listPoint[x].X, g.listPoint[x].Y);
            Point point2 = new Point(g.listPoint[y].X, g.listPoint[y].Y);
            graph.DrawLine(p, point1, point2);
            graph.DrawString($"{g.adj[x, y]}", new Font("Fira Code", 10), Brushes.Black, new Point((point1.X + point2.X) / 2 - 8, (point1.Y + point2.Y) / 2 + 8));
        }
        //Hàm xóa các thông tin được nhập vào trước đó trước khi nhập một input khác 
        //Thông báo lỗi khi điểm đi và điểm đến trùng nhau
        private void cbSource_SelectedIndexChanged(object creator, EventArgs e)
        {
            if (cbDiemdi.SelectedIndex != -1 && cbDiemden.SelectedIndex != -1)
            {
                BanDoPhiaNam.Controls.Clear();
                BanDoPhiaNam.Refresh();
                DrawLine();
                g.pathIndex.Clear();
                tbKM.Clear();
                tbLit.Clear();
                tbTongCongChiPhi.Clear();
                tbTuyenDuongDi.Clear();
                g.FindPaths(cbDiemdi.SelectedItem.ToString(), cbDiemden.SelectedIndex.ToString(),tbKM,tbLit, tbTongCongChiPhi, tbTuyenDuongDi);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
            if (cbDiemdi.SelectedIndex == cbDiemden.SelectedIndex)
            {
                MessageBox.Show("Điểm xuất phát và điểm đến không được phép trùng nhau !");
            }
        }
        private void cbDestination_SelectedIndexChanged(object creator, EventArgs e)
        {
            if (cbDiemdi.SelectedIndex != -1 && cbDiemden.SelectedIndex != -1)
            {
                BanDoPhiaNam.Controls.Clear();
                BanDoPhiaNam.Refresh();
                DrawLine();
                g.pathIndex.Clear();
                tbKM.Clear();
                tbLit.Clear();
                tbTongCongChiPhi.Clear();
                tbTuyenDuongDi.Clear();
                g.FindPaths(cbDiemdi.SelectedItem.ToString(), cbDiemden.SelectedIndex.ToString(),tbKM ,tbLit, tbTongCongChiPhi, tbTuyenDuongDi);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
            if (cbDiemdi.SelectedIndex == cbDiemden.SelectedIndex)
            {
                MessageBox.Show("Điểm xuất phát và điểm đến không được phép trùng nhau !");
            }    
        }
       
        private void DrawPathLine(int i)//Hàm vẽ lại tuyến đường tiết kiệm nhất đã được tính toán
                                        //trước đó lên bản đồ
        {
            Graphics graph = BanDoPhiaNam.CreateGraphics();
            Pen p = new Pen(Color.Aqua, 2);
            Point point1 = new Point(g.pathIndex[i].X, g.pathIndex[i].Y);
            Point point2 = new Point(g.pathIndex[i + 1].X, g.pathIndex[i + 1].Y);
            graph.DrawLine(p, point1, point2);
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BanDoPhiaNam_Click(object sender, EventArgs e)
        {

        }
    }
}
