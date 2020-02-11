using System;
using System.Collections.Generic;
using System.Text;

namespace FirstEngineeringStudy.DataLayer.DataModels
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Employee Employee { get; set; }
        public bool IsDeleted { get; set; }
    }
}
