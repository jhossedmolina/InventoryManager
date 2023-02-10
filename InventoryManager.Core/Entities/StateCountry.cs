using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class StateCountry
    {
        public StateCountry()
        {
            MunicipalityCountries = new HashSet<MunicipalityCountry>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<MunicipalityCountry> MunicipalityCountries { get; set; }
    }
}
