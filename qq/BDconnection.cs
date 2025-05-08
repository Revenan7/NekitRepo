using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class BDconnection
    {
        private static HorseClubDBEntities _k8SLoverEntities;

        public static HorseClubDBEntities DB = GetContext();
        public static HorseClubDBEntities GetContext()
        {
            if(_k8SLoverEntities == null )
            {
                _k8SLoverEntities = new HorseClubDBEntities();
            }
            return _k8SLoverEntities;
        }
    }
}
