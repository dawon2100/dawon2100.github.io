using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace CurveBooleanBoundaryRegion
{
    public class CurveBooleanBoundaryRegionInfo : GH_AssemblyInfo
    {
        public override string Name => "CurveBooleanBoundaryRegion";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("80605698-BB25-452E-82E7-B8A0D7E11528");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}