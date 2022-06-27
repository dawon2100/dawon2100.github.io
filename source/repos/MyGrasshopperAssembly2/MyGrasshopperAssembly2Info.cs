using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyGrasshopperAssembly2
{
    public class MyGrasshopperAssembly2Info : GH_AssemblyInfo
    {
        public override string Name => "MyGrasshopperAssembly2";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("860C514F-A5C9-4DD0-8C21-C72B45B1A951");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}