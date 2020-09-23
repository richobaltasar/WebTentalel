using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTentakel.Models
{
    public class PageTitlesModel
    {
        public string PageaNames { get; set; }
        public Button ButtonAction { get; set; }
        
    }

    public class Button
    {
        public string Class { get; set; }
        public string Icon { get; set; }
        public string Text { get; set; }

        public string Action { get; set; }
        public string Contoroller { get; set; }
    }
}
