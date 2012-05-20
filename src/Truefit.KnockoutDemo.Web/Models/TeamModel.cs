using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Truefit.KnockoutDemo.Web.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string LogoUrl { get; set; }
        public string Manager { get; set; }        
    }
}