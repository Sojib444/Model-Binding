
using Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee;
namespace Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee.RepositoryClass
{
    public class EmpolyeeRepository : IEmpolyee
    {

        List<Empolyee> empolyees = new List<Empolyee>()
        {
            new Empolyee(){Id=1,Name="Sojib",Address="Pabna",Department=EnumEmpolyee.EEE},
            new Empolyee(){Id=2,Name="Abir",Address="Dhaka",Department=EnumEmpolyee.Finance},
            new Empolyee(){Id=3,Name="Kabir",Address="Jamalpur",Department=EnumEmpolyee.Potitical_science},
            new Empolyee(){Id=4,Name="Shakhawat",Address="Karimabad",Department=EnumEmpolyee.Bangla},
            new Empolyee(){Id=5,Name="Shariar",Address="India",Department=EnumEmpolyee.BiomedicalEngineering},
            new Empolyee(){Id=6,Name="Rabiul",Address="Khulna",Department=EnumEmpolyee.BTGE},
            new Empolyee(){Id=7,Name="Shopon",Address="Bogura",Department=EnumEmpolyee.Finance}
        };

        public Empolyee Add(Empolyee empolyee)
        {
            empolyees.Add(empolyee);
            return empolyee;
        }

        public Empolyee Delete(int id)
        {
            var emp =empolyees.Where(e => e.Id == id).FirstOrDefault();
            if(emp!=null)
            {
                empolyees.Remove(emp);
            }
            return emp;
        }

        public Empolyee get(int id)
        {
            return empolyees.Where(e => e.Id == id).FirstOrDefault();

        }

        public List<Empolyee> getList()
        {
            return empolyees;
        }

        public Empolyee Upadate(Empolyee empolyee)
        {
            var emp=empolyees.Where(e => e.Id == empolyee.Id).FirstOrDefault();
            emp.Name = empolyee.Name;
            emp.Address = empolyee.Address;
            emp.Id = empolyee.Id;
            emp.Department = empolyee.Department;


            return emp;
        }
    }
}
