using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Con_Ong
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
             int a;
            do
            {
                Console.WriteLine("1. Tao Dan Ong");
                Console.WriteLine("2. Tan Cong Dan Ong");
                Console.WriteLine("3. Hien Thong Tin Dan Ong");
                Console.WriteLine("*. Nhan Phim Bat Ky De Thoat Chuong trinh");
                int luaChon = int.Parse(Console.ReadLine());
                
                switch (luaChon)
                {
                    case 1:
                        Random ran = new Random();
                        int soLuong = ran.Next(10);
                        game.KhoiTaoDanOng(soLuong);
                        break;
                    case 2:
                        //Console.WriteLine("2. Tan Cong Dan Ong");
                        game.TanCongDanOng();
                        break;
                    case 3:
                        game.InDanhSach();
                        break;
                    default:
                        return;
                }
                a = luaChon;
            } while (a != 1 || a != 2 || a != 3);
        }
    }
}
