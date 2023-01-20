using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiSprinklers
{ 
    public class ModConfig
    {
        public int SprinklerRange { get; set; } = 3;
        public bool ActivateOnPlacement { get; set; } = true;
        public bool ActivateOnAction { get; set; } = true;
    }
}