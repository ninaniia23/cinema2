using Cinema.DTOs;
using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cinema.Views.Admin.ShowtimeManagementVM
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            var db = new cinemaContext();
            var list = (from xc in db.SuatChieus
                        join p in db.Phims on xc.MaSuat equals p.MaSuat
                        join t in db.TheLoais on p.MaTheLoaiChinh equals t.MaTheLoai
                        select new
                        {
                            MaPhim = p.MaPhim,
                            TenPhim = p.TenPhim,
                            TenTheLoaiChinh = t.TenTheLoai,
                            ThoiLuong = p.ThoiLuong,
                            GioBatDau = xc.GioBatDau+":"+xc.PhutBatDau,
                            PhutBatDau = xc.PhutBatDau
                        }).ToList();

            List<PhimDTO> listDTO = new List<PhimDTO>();
            foreach(var i in list)
            {
                listDTO.Add(new PhimDTO(i.MaPhim, i.TenPhim,
                    i.TenTheLoaiChinh, i.ThoiLuong, i.GioBatDau, i.PhutBatDau));
            }

            listShowTime.ItemsSource = listDTO;

        }

      
        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void film_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
