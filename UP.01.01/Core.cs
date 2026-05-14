using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP._01._01
{
    internal class Core
    {
        public static kuza_upEntities2 Context = new kuza_upEntities2();
    }
}

namespace UP._01._01
{
    public partial class Book
    {
        //public string AthtorName { get {
        //        var g = Core.Context.User.FirstOrDefault(u=>u.Id == IdAuthor);
        //        if (g != null) return g.Name;
        //        return null;
        //    }
        //}
    }
}