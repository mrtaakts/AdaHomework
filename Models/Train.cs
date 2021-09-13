using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaHomework.Models
{
    public class Train : BaseModel
    {
        public List<Vagon> Vagonlar { get; set; }
    }
}
