using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyGrasshopperAssembly20220207test
{
    public class MyGrasshopperAssembly20220207testInfo : GH_AssemblyInfo
    {
        public override string Name => "MyGrasshopperAssembly20220207test";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("CA9F78FE-134C-4D68-A081-97679FB14FC8");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}