using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL
{
    public class Nhom
    {
        public int MaNhom { get; set; }
        public string TenNhom { get; set; }
        public static List<LienLac> ListLienLac { get; set; }

        public static List<Nhom> getListNhom(string pathDataGroup)
        {
            List<Nhom> listNhom = new List<Nhom>();
            string[] rows = File.ReadAllLines(pathDataGroup);
            foreach(string row in rows)
            {
                string[] values = row.Split('|');
                listNhom.Add(new Nhom { 
                    MaNhom = Convert.ToInt32(values[0]),
                    TenNhom = values[1]
                });
            }
            return listNhom;
        }
        public static void themNhom(string pathDataGroup, string tenNhom)
        {
            List<Nhom> listNhom = getListNhom(pathDataGroup);
            if (listNhom.Count == 0)
            {
                File.WriteAllLines(pathDataGroup, new string[] { "0|" + tenNhom });
            }
            else
            {
                int maNhom = listNhom[listNhom.Count - 1].MaNhom + 1;
                File.AppendAllLines(pathDataGroup, new string[] { maNhom + "|" + tenNhom });
            }

        }

        public static void xoaNhom(string pathDataGroup, int maNhom) {
            List<Nhom> listNhom = getListNhom(pathDataGroup);
            File.Delete(pathDataGroup);
            foreach (Nhom nhom in listNhom)
            {
                if(nhom.MaNhom != maNhom)
                {
                    File.AppendAllLines(pathDataGroup, new string[] { nhom.MaNhom + "|" + nhom.TenNhom });
                }
            }
        }
    }
}
