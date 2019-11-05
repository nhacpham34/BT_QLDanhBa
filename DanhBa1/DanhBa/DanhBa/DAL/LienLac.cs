using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL
{
    public class LienLac
    {
        public int MaLienLac { get; set; }
        public string TenLienLac { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public static List<LienLac> getContactList(string pathDataContact, int maNhom)
        {
            List<LienLac> listContact = new List<LienLac>();

            string[] rows = File.ReadAllLines(pathDataContact);
            foreach (string row in rows)
            {
                string[] values = row.Split('|');
                if (Convert.ToInt32(values[5]) == maNhom)
                {
                    listContact.Add(new LienLac { 
                        MaLienLac = Convert.ToInt32(values[0]),
                        TenLienLac = values[1],
                        Email = values[2],
                        SoDienThoai = values[3],
                        DiaChi = values[4]
                    });
                }
            }

            return listContact;
        }
        public static List<LienLac> getContactList(string pathDataContact)
        {
            List<LienLac> listContact = new List<LienLac>();

            string[] rows = File.ReadAllLines(pathDataContact);
            foreach (string row in rows)
            {
                string[] values = row.Split('|');
                
                listContact.Add(new LienLac
                {
                    MaLienLac = Convert.ToInt32(values[0]),
                    TenLienLac = values[1],
                    Email = values[2],
                    SoDienThoai = values[3],
                    DiaChi = values[4]
                });
            
            }

            return listContact;
        }
        public static void themLienLac(string pathDataContact, string tenLienLac, string email, string soDienThoai, string diaChi, int maNhom)
        {
            List<LienLac> listContact = getContactList(pathDataContact);
            if (listContact.Count == 0)
            {
                File.WriteAllLines(pathDataContact, new string[] {
                    "0"+"|"+tenLienLac+"|"+email+"|"+soDienThoai+"|"+diaChi+"|"+maNhom
                });
            }
            else
            {
                int maLienLac = listContact[listContact.Count - 1].MaLienLac + 1;
                File.AppendAllLines(pathDataContact, new string[] {
                    maLienLac+"|"+tenLienLac+"|"+email+"|"+soDienThoai+"|"+diaChi+"|"+maNhom
                });
            }
        }
    }
}