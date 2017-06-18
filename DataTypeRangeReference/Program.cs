// ***********************************************************************
// Assembly         : DataTypeRangeReference
//
// Author           : Nick
// Created          : 06-18-2017
//
// Last Modified By : Nick
// Last Modified On : 06-18-2017
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
            ConcatenationTool.JoinByteTypes(Byte.MinValue, Byte.MaxValue);
            ConcatenationTool.JoinByteTypes(SByte.MinValue, SByte.MaxValue);

            // Short
            ConcatenationTool.JoinIntTypes(Int16.MinValue, Int16.MaxValue);
            ConcatenationTool.JoinIntTypes(UInt16.MinValue, UInt16.MaxValue);

            // Int
            ConcatenationTool.JoinIntTypes(Int32.MinValue, Int32.MaxValue);
            ConcatenationTool.JoinIntTypes(UInt32.MinValue, UInt32.MaxValue);

            // Long
            ConcatenationTool.JoinIntTypes(Int64.MinValue, Int64.MaxValue);
            ConcatenationTool.JoinIntTypes(UInt64.MinValue, UInt64.MaxValue);

            // Decimal
            ConcatenationTool.JoinFloatingTypes(Decimal.MinValue, Decimal.MaxValue);

            // Float
            ConcatenationTool.JoinFloatingTypes(Single.MinValue, Single.MaxValue);

            // Double
            ConcatenationTool.JoinFloatingTypes(Double.MinValue, Double.MaxValue);

            Exit();
        }

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
