using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyFirstComponent1
{
    public class MyFirstComponent1Info : GH_AssemblyInfo
    {
        public override string Name => "MyFirstComponent1";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("8F1D91FE-0D0B-4447-826B-3BCDCD84826B");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}