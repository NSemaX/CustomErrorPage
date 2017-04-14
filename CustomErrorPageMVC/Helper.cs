using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomErrorPageMVC
{
    public static class Helper
    {
        public static List<CustomClass> FullList()
        {

            List<CustomClass> result = new List<CustomClass>()
        {
            new CustomClass(){  Code = 1,  Description = "Jessica" },
            new CustomClass(){ Code = 2, Description = "Mandy" }
        };


            return result;
        }
        public static List<CustomClass> FullListError()
        {
            return null;
        }
    }
}