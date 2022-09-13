using Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee.contex;

namespace Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee.RepositoryClass
{
    public class SqlServerRepository : IEmpolyee
    {
        private readonly EmpolyeeContecxt _context;
        public SqlServerRepository(EmpolyeeContecxt context)
        {
            _context = context;
        }
        public Empolyee Add(Empolyee empolyee)
        {
            _context.empolyees.Add(empolyee);
            _context.SaveChanges();
            return empolyee;
        }

        public Empolyee Delete(int id)
        {
            Empolyee? emp = _context.empolyees.Find(id);
            if (emp != null)
            {
                _context.empolyees.Remove(emp);
                _context.SaveChanges();
            }
            return emp;

        }

        public Empolyee get(int id)
        {
             Empolyee emp= _context.empolyees.Find(id);
            return emp;
        }

        public List<Empolyee> getList()
        {
            return _context.empolyees.ToList();
        }

        public Empolyee Upadate(Empolyee empolyee)
        {
           var emp= _context.empolyees.Attach(empolyee);
           emp.State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return empolyee;

        }
    }
}
