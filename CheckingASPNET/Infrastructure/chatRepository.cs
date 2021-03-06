﻿using CheckingASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckingASPNET.Infrastructure
{
    

    public static class ChatRepository
    {
        //// readonly variable
        //public static List<Message> Foo
        //{
        //    get
        //    {
        //        return "foo";
        //    }
        //}

        // read-write variable
        public static List<Message> chatHistory
        {
            get
            {
                return HttpContext.Current.Application["chatHistory"] as List<Message>;
            }
            set
            {
                HttpContext.Current.Application["chatHistory"] = value;
            }
        }
    }
}