using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTOs
{
    public class PhimDTO
    {
        public PhimDTO(int maPhim, string? tenTheLoaiChinh, string? tenPhim, int? thoiLuong, string? gioBatDau, int? phutBatDau)
        {
            MaPhim = maPhim;
            TenTheLoaiChinh = tenTheLoaiChinh;
            TenPhim = tenPhim;
            ThoiLuong = thoiLuong;
            GioBatDau = gioBatDau;
            PhutBatDau = phutBatDau;
        }

        public PhimDTO(int maPhim, string? tenTheLoaiChinh, string? tenPhim, int? thoiLuong)
        {
            MaPhim = maPhim;
            TenTheLoaiChinh = tenTheLoaiChinh;
            TenPhim = tenPhim;
            ThoiLuong = thoiLuong;
        }

        public int MaPhim { get; set; }
        public string? TenTheLoaiChinh { get; set; }
        public string? TenPhim { get; set; }
        public int? ThoiLuong { get; set; }
        public string? GioBatDau { get; set; }
        public int? PhutBatDau { get; set; }



    }
}
