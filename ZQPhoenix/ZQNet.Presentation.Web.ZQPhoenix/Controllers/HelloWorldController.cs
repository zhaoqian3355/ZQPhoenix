﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZQNet.Presentation.Web.ZQPhoenix.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name,int id=1)
        //{
        //    return HttpUtility.HtmlEncode("Hello "+name+", NumTimes is : "+id);
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(int id,string name)
        {
            return HttpUtility.HtmlEncode("id: "+id+ ", Hello " + name);
        }
    }
}