using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyProject12
{
    public class MyProject12Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "MyProject12";
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
                return new Guid("37a10303-b49c-4451-b409-f8a5b5ab811a");
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
