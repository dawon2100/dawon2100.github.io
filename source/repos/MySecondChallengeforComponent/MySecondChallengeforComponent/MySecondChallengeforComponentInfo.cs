using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MySecondChallengeforComponent
{
    public class MySecondChallengeforComponentInfo : GH_AssemblyInfo
    {
        public override string Name => "MySecondChallengeforComponent";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("A1E27C82-0940-4F0B-9E37-6EFEEA6FDA35");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}