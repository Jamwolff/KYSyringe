using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace KYSyringe
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug Printouts")]
        public bool Debug { get; set; } = false;

        [Description("List of LJ-429s.")]
        public List<Syringe> Syringes { get; private set; } = new()
        {
            new Syringe(),
        };
         

    }
}