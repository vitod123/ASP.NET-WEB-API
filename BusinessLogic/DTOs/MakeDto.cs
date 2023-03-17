using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class MakeDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }     // Название производителя
        public string Country { get; set; }  // Страна производителя
    }
}
