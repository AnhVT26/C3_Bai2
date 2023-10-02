using C3_Bai2.Controller.Repositories;
using C3_Bai2.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_Bai2.Controller.Services
{
    internal class SachService
    {
        SachRepository _repos;
        public SachService()
        {
            _repos = new();
        }
        public void ThemSach(Sach sach)
        {
            if (_repos.AddSach(sach))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void SuaSach(Sach sach)
        {
            var temp = _repos.GetSaches(null).FirstOrDefault(s => s.Id == sach.Id);
            temp.Ten = sach.Ten;
            temp.Ma = sach.Ma;
            temp.TrangThai  = sach.TrangThai;
            temp.IdNxb = sach.IdNxb;
            if (_repos.UpdateSach(temp))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public List<Sach> GetSaches(string input) 
        {
            return _repos.GetSaches(input);
        }
        public List<Nxb> GetNxbs(string input)
        {
            return _repos.GetNxbs(input);
        }
    }
}
