﻿using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyProject1_1_v6
{
    public class MyProject1_1_v6Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "MyProject11v6";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("c02a462d-8174-4d2d-a013-362e0249887e");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
