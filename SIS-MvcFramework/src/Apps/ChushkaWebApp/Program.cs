﻿using SIS.MvcFramework;

namespace ChushkaWebApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebHost.Start(new Startup());
        }
    }
}
