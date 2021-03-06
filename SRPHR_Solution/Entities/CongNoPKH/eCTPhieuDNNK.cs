using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTPhieuDNNK
    {
        public string soPDNXK { get; set; }
        public string maSP { get; set; }
        public int soluong { get; set; }
        public string Ghichu { get; set; }
        public eCTPhieuDNNK()
        {
            this.soPDNXK = "";
            this.maSP = "";
            this.soluong = 0;
            this.Ghichu = "";
        }
        public eCTPhieuDNNK(string soPDNXK, string maSP, int soluong, string Ghichu)
        {
            this.soPDNXK = soPDNXK;
            this.maSP = maSP;
            this.soluong = soluong;
            this.Ghichu = Ghichu;
        }
        public override int GetHashCode()
        {
            return soPDNXK.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eCTPhieuDNNK ctpdnnk = (eCTPhieuDNNK)obj;
            return ctpdnnk.Equals(ctpdnnk.soPDNXK);
        }
    }
}
