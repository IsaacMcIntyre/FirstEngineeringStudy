using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEngineeringStudy.ViewModels.Club
{
    public class ClubVm
    {
        public ClubVm(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
