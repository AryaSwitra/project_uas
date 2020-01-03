using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_uas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = row.Visible = seat.Visible = false;
            senin.Checked = selasa.Checked = rabu.Checked = kamis.Checked = jumat.Checked = sabtu.Checked = minggu.Checked = false;
            jam_17_30.Checked = jam_14_30.Checked = jam_16_50.Checked = jam_19_30.Checked = jam_21_30.Checked = jam_22_10.Checked = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbuser.Text == "arya" && tbpass.Text == "123"){
                pjudul_film.Visible = true;
                pharga.Visible = true;
                //ppemesanan.Visible = true;
            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            Button PilihJudul = (Button)sender;
            lbjudul.Text = PilihJudul.Name;

            pharga.Visible = true;
            pjudul_film.Visible = false;
            ppemesanan.Visible = false;
            pstruk.Visible = false;
        }

        private void ppemesanan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpilih_kursi_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = row.Visible = seat.Visible = btnprint.Visible = true;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (senin.Checked == true ||
                selasa.Checked == true ||
                rabu.Checked == true ||
                kamis.Checked == true ||
                jumat.Checked == true ||
                sabtu.Checked == true ||
                minggu.Checked == true) { }
            else { MessageBox.Show("data belum lengkap", "warning"); }

            if (jam_17_30.Checked == true ||
                jam_14_30.Checked == true ||
                jam_16_50.Checked == true ||
                jam_19_30.Checked == true ||
                jam_21_30.Checked == true ||
                jam_22_10.Checked == true) { }
            else { MessageBox.Show("data belum lengkap", "warning"); }

            if (row.Text == "ROW" || seat.Text == "SEAT")
            {
               
                MessageBox.Show("data belum lengkap", "warning");
            }
            else {
                ppemesanan.Visible = false;
                //panel1.Visible = true;
                pstruk.Visible = true;
            }
            if (Kursi_Load == Color.Yellow) { 
                Button pilihkursi = (Button)sender;
                lbseat.Text = pilihkursi.Text;
            }
        }

        //private void btn2d_Click_1(object sender, EventArgs e)
        //{
            //ppemesanan.Visible = true;
            //pharga.Visible = false;
            //pjudul_film.Visible = false;
        //}

        private void Click_hari(object sender, EventArgs e)
        {
            RadioButton PilihHari = (RadioButton)sender;
            lbday.Text = PilihHari.Text;

        }

        private void Kursi_Load(object sender, EventArgs e)
        {
            a1.BackColor = Color.Red;
            a2.BackColor = Color.Red;
            a3.BackColor = Color.Red;
            a4.BackColor = Color.Red;
            a5.BackColor = Color.Red;
            a6.BackColor = Color.Red;
            a7.BackColor = Color.Red;
            a8.BackColor = Color.Red;
            a9.BackColor = Color.Red;
            a10.BackColor = Color.Red;
            b1.BackColor = Color.Red;
            b2.BackColor = Color.Red;
            b3.BackColor = Color.Red;
            b4.BackColor = Color.Red;
            b5.BackColor = Color.Red;
            b6.BackColor = Color.Red;
            b7.BackColor = Color.Red;
            b8.BackColor = Color.Red;
            b9.BackColor = Color.Red;
            b10.BackColor = Color.Red;
            c1.BackColor = Color.Red;
            c2.BackColor = Color.Red;
            c3.BackColor = Color.Red;
            c4.BackColor = Color.Red;
            c5.BackColor = Color.Red;
            c6.BackColor = Color.Red;
            c7.BackColor = Color.Red;
            c8.BackColor = Color.Red;
            c9.BackColor = Color.Red;
            c10.BackColor = Color.Red;
            d1.BackColor = Color.Red;
            d2.BackColor = Color.Red;
            d3.BackColor = Color.Red;
            d4.BackColor = Color.Red;
            d5.BackColor = Color.Red;
            d6.BackColor = Color.Red;
            d7.BackColor = Color.Red;
            d8.BackColor = Color.Red;
            d9.BackColor = Color.Red;
            d10.BackColor = Color.Red;
            e1.BackColor = Color.Red;
            e2.BackColor = Color.Red;
            e4.BackColor = Color.Red;
            e5.BackColor = Color.Red;
            e6.BackColor = Color.Red;
            e7.BackColor = Color.Red;
            e8.BackColor = Color.Red;
            e9.BackColor = Color.Red;
            e10.BackColor = Color.Red;
            f1.BackColor = Color.Red;
            f2.BackColor = Color.Red;
            f3.BackColor = Color.Red;
            f4.BackColor = Color.Red;
            f5.BackColor = Color.Red;
            f6.BackColor = Color.Red;
            f7.BackColor = Color.Red;
            f8.BackColor = Color.Red;
            f9.BackColor = Color.Red;
            f10.BackColor = Color.Red;
            g1.BackColor = Color.Red;
            g2.BackColor = Color.Red;
            g3.BackColor = Color.Red;
            g4.BackColor = Color.Red;
            g5.BackColor = Color.Red;
            g6.BackColor = Color.Red;
            g7.BackColor = Color.Red;
            g8.BackColor = Color.Red;
            g9.BackColor = Color.Red;
            g10.BackColor = Color.Red;
            h1.BackColor = Color.Red;
            h2.BackColor = Color.Red;
            h3.BackColor = Color.Red;
            h4.BackColor = Color.Red;
            h5.BackColor = Color.Red;
            h6.BackColor = Color.Red;
            h7.BackColor = Color.Red;
            h8.BackColor = Color.Red;
            h9.BackColor = Color.Red;
            h10.BackColor = Color.Red;
            i1.BackColor = Color.Red;
            i2.BackColor = Color.Red;
            i3.BackColor = Color.Red;
            i4.BackColor = Color.Red;
            i5.BackColor = Color.Red;
            i6.BackColor = Color.Red;
            i7.BackColor = Color.Red;
            i8.BackColor = Color.Red;
            i9.BackColor = Color.Red;
            i10.BackColor = Color.Red;

            //Button PilihSeat = (Button)sender;
            //lbseat.Text = PilihSeat.Text;
        }

        private void seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(row.Text == "A" && seat.Text == "1"){
                a1.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "2"){
                a2.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "3"){
                a3.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "4"){
                a4.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "5"){
                a5.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "6"){
                a6.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "7"){
                a7.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "8"){
                a8.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "9"){
                a9.BackColor = Color.Yellow;
            }
            else if(row.Text == "A" && seat.Text == "10"){
                a10.BackColor = Color.Yellow;
            }
            else if(row.Text == "B" && seat.Text == "1"){
                b1.BackColor = Color.Yellow;
            }
            else if(row.Text == "B" && seat.Text == "2"){
                b2.BackColor = Color.Yellow;
            }
            else if(row.Text == "B" && seat.Text == "3"){
                b3.BackColor = Color.Yellow;
            }
            else if(row.Text == "B" && seat.Text ==  "4"){
                b4.BackColor = Color.Yellow;
            }
            else if (row.Text == "B" && seat.Text == "5")
            {
                b5.BackColor = Color.Yellow;
            }
            else if (row.Text == "B" && seat.Text == "6")
            {
                b6.BackColor = Color.Yellow;
            }
            else if (row.Text == "B" && seat.Text == "7")
            {
                b7.BackColor = Color.Yellow;
            }
            else if (row.Text == "B" && seat.Text == "8")
            {
                b8.BackColor = Color.Yellow;
            }
            else if (row.Text == "B" && seat.Text == "9")
            {
                b9.BackColor = Color.Yellow;
            }
            else if (row.Text == "B" && seat.Text == "10")
            {
                b10.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "1")
            {
                c1.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "2")
            {
                c2.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "3")
            {
                c3.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "4")
            {
                c4.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "5")
            {
                c5.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "6")
            {
                c6.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "7")
            {
                c7.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "8")
            {
                c8.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "9")
            {
                c9.BackColor = Color.Yellow;
            }
            else if (row.Text == "C" && seat.Text == "10")
            {
                c10.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "1")
            {
                d1.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "2")
            {
                d2.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "3")
            {
                d3.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "4")
            {
                d4.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "5")
            {
                d5.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "6")
            {
                d6.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "7")
            {
                d7.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "8")
            {
                d8.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "9")
            {
                d9.BackColor = Color.Yellow;
            }
            else if (row.Text == "D" && seat.Text == "10")
            {
                d10.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "1")
            {
                e1.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "2")
            {
                e2.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "3")
            {
                e3.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "4")
            {
                e4.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "5")
            {
                e5.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "6")
            {
                e6.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "7")
            {
                e7.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "8")
            {
                e8.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "9")
            {
                e9.BackColor = Color.Yellow;
            }
            else if (row.Text == "E" && seat.Text == "10")
            {
                e10.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "1")
            {
               f1.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "2")
            {
                f2.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "3")
            {
                f3.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "4")
            {
                f4.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "5")
            {
                f5.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "6")
            {
                f6.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "7")
            {
                f7.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "8")
            {
                f8.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "9")
            {
                f9.BackColor = Color.Yellow;
            }
            else if (row.Text == "F" && seat.Text == "10")
            {
                f10.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "1")
            {
                g1.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "2")
            {
                g2.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "3")
            {
                g3.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "4")
            {
                g4.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "5")
            {
                g5.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "6")
            {
                g6.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "7")
            {
                g7.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "8")
            {
                g8.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "9")
            {
                g9.BackColor = Color.Yellow;
            }
            else if (row.Text == "G" && seat.Text == "10")
            {
                g10.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "1")
            {
                h1.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "2")
            {
                h2.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "3")
            {
                h3.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "4")
            {
                h4.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "5")
            {
                h5.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "6")
            {
                h6.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "7")
            {
                h7.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "8")
            {
                h8.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "9")
            {
                h9.BackColor = Color.Yellow;
            }
            else if (row.Text == "H" && seat.Text == "10")
            {
                h10.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "1")
            {
                i1.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "2")
            {
                i2.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "3")
            {
                i3.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "4")
            {
                i4.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "5")
            {
                i5.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "6")
            {
                i6.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "7")
            {
                i7.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "8")
            {
                i8.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "9")
            {
                i9.BackColor = Color.Yellow;
            }
            else if (row.Text == "I" && seat.Text == "10")
            {
                i10.BackColor = Color.Yellow;
            }

            ComboBox PilihKursi = (ComboBox)sender;
            lbseat.Text = PilihKursi.Text;
        }

        private void Click_waktu(object sender, EventArgs e)
        {
            RadioButton PilihWaktu = (RadioButton)sender;
            lbtime.Text = PilihWaktu.Text;
        }

        private void row_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox PilihBaris = (ComboBox)sender;
            lbrow.Text = PilihBaris.Text;
        }

        private void Click_studio(object sender, EventArgs e)
        {
            Button PilihStudio = (Button)sender;
            lbstudio.Text = PilihStudio.Text;

            ppemesanan.Visible = true;
            pharga.Visible = false;
            pjudul_film.Visible = false;
        }

        private void pstruk_Paint(object sender, PaintEventArgs e)
        {
            if (lbday.Text == "senin" || 
                lbday.Text == "selasa" || 
                lbday.Text == "rabu" || 
                lbday.Text == "kamis" || 
                lbday.Text == "jumat" && 
                lbstudio.Text == "3D")
            {
                lbprice.Text = "Rp 40.000";
            }
            else if (lbday.Text == "sabtu" ||
                  lbday.Text == "minggu" &&
                  lbstudio.Text == "3D")
            {
                lbprice.Text = "Rp 50.000";
            }

            if(lbday.Text == "senin" || lbday.Text == "selasa" || lbday.Text == "rabu" || lbday.Text == "kamis" || lbday.Text == "jumat" && 
                lbstudio.Text == "2D")
            {
                lbprice.Text = "Rp 25.000";
            }
            else if (lbday.Text == "sabtu" || lbday.Text == "minggu" && lbstudio.Text == "2D")
            {
                lbprice.Text = "Rp 35.000";
            }

            lborder.Text = DateTime.Now + "";
        }
    }
}
