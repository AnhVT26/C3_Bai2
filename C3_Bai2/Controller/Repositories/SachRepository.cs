using C3_Bai2.Model.Context;
using C3_Bai2.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_Bai2.Controller.Repositories
{
    internal class SachRepository
    {
        DBContext _context;
        public SachRepository()
        {
            _context = new();
        }
        public List<Sach> GetSaches(string search)
        {
            if (search == null)
            {
                return _context.Saches.ToList();
            }
            return _context.Saches.Where(s => s.Ten.Contains(search)).ToList();
        }
        public List<Nxb> GetNxbs(string search)
        {
            if (search == null)
            {
                return _context.Nxbs.ToList();
            }
            return _context.Nxbs.Where(s=>s.Ten.Contains(search)).ToList();
        }

        public bool AddSach(Sach sach)
        {
            if (sach == null)
            {
                return false;
            }
            sach.Id = Guid.NewGuid();
            _context.Add(sach);
            _context.SaveChanges();
            return true;    
        }
        public bool UpdateSach(Sach sach)
        {
            if (sach == null)
            {
                return false;
            }
            _context.Update(sach);
            _context.SaveChanges();
            return true;
        }
    }
}
