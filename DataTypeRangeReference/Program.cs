// ***********************************************************************
// Assembly         : DataTypeRangeReference
//
// Author           : Nick
// Created          : 06-18-2017
//
// Last Modified By : Nick
// Last Modified On : 06-20-2017
//
// License          : GNU General Public License v3.0
// ***********************************************************************

using System;

namespace DataTypeRangeReference
{
    public class Program
    {
        private static void Main()
        {
            IntroduceUser();

            // Byte
            JoinByteTypes(Byte.MinValue, Byte.MaxValue);
            JoinByteTypes(SByte.MinValue, SByte.MaxValue);

            // Short
            JoinIntTypes(Int16.MinValue, Int16.MaxValue);
            JoinUIntTypes(UInt16.MinValue, UInt16.MaxValue);

            // Int
            JoinIntTypes(Int32.MinValue, Int32.MaxValue);
            JoinUIntTypes(UInt32.MinValue, UInt32.MaxValue);

            // Long
            JoinIntTypes(Int64.MinValue, Int64.MaxValue);
            JoinUIntTypes(UInt64.MinValue, UInt64.MaxValue);

            // Decimal
            JoinFloatingTypes(Decimal.MinValue, Decimal.MaxValue);

            // Float
            JoinFloatingTypes(Single.MinValue, Single.MaxValue);

            // Double
            JoinFloatingTypes(Double.MinValue, Double.MaxValue);

            Exit();
        }
        #region Primary Methods

        private static string Min { get; } = "Min:";
        private static string Max { get; } = "Max:";

        private static void JoinByteTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue}");
            Console.WriteLine($"{Max,11} {maxValue}");
        }

        private static void JoinUIntTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue}");
            Console.WriteLine($"{Max,11} {maxValue:#,#}");
        }

        private static void JoinIntTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue:#,#}");
            Console.WriteLine($"{Max,11} {maxValue:#,#}");
        }

        private static void JoinFloatingTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue:#0.0e0}");
            Console.WriteLine($"{Max,11} {maxValue,7:#0.0e0}");
        }

        #endregion

        #region Helper Methods

        private static void IntroduceUser()
        {
            Console.WriteLine("This program is meant to be used as a reference if you need to know the minimum or maximum value of a given type.");
            Console.WriteLine();
        }

        private static void Exit()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        #endregion

    }
}
