using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranChiTam
{
    class hocsinh
    {
        private string hoTen;
        private string cmnd;
        private string diaChi;
        private string dateOfBirth;

        public hocsinh(string hoTen, string cmnd, string diaChi, string dateOfBirth)
        {
            this.hoTen = hoTen;
            this.cmnd = cmnd;
            this.diaChi = diaChi;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
