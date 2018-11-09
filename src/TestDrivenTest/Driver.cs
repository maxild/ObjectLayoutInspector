using System.Diagnostics.CodeAnalysis;
using ObjectLayoutInspector;

#pragma warning disable 649 // Field is never assigned to, and will always have its default value 'value'

namespace TestDrivenTest
{
    // See https://github.com/jcansdale/TestDriven.Net-Issues/issues/98 for th3 reason to use
    // netstandard 2.0 library for running learning tests with TestDriven.Net v4.3+.
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Local")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class Driver
    {
        struct Point2DStruct
        {
            public int X;
            public int Y;
        }

        class Point2DClass
        {
            public int X;
            public int Y;
        }

        public void Print()
        {
            TypeLayout.PrintLayout<Point2DStruct>();
            TypeLayout.PrintLayout<Point2DClass>();
        }
    }
}
