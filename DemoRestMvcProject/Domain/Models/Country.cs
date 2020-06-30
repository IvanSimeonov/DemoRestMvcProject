using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DemoRestMvcProject.Domain.Models
{
    public enum Country: byte
    {
        [Description("BG")]
        Bulgaria = 1,

        [Description("DE")]
        Germany = 2,

        [Description("CH")]
        Switzerland = 3
    }
}