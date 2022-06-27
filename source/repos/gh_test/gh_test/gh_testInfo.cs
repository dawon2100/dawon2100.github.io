using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace gh_test
{
    public class gh_testInfo : GH_AssemblyInfo
    {
        public override string Name => "gh_test";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("14C013D2-2E8F-4671-9742-14BC9DB10CB2");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}