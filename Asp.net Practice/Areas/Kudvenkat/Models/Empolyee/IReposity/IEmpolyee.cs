

namespace Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee
{
    public interface IEmpolyee
    {

        Empolyee get(int id);
        List<Empolyee> getList();
        Empolyee Add(Empolyee empolyee);
        Empolyee Upadate(Empolyee empolyee);
        Empolyee Delete(int id);
    }
}
