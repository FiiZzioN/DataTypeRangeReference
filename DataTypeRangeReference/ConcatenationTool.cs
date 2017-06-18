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
using System.Collections.Generic;

namespace DataTypeRangeReference
{
    public static class ConcatenationTool
    {
        private static string Min { get; } = "Min:";
        private static string Max { get; } = "Max:";

        public static void JoinByteTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue}");
            Console.WriteLine($"{Max,11} {maxValue}");
        }

        public static void JoinIntTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue}");
            Console.WriteLine($"{Max,11} {maxValue,6:#,#}");
        }

        public static void JoinFloatingTypes(object minValue, object maxValue)
        {
            Console.WriteLine($"{minValue.GetType().Name}:");
            Console.WriteLine($"{Min,11} {minValue:#0.0e0}");
            Console.WriteLine($"{Max,11} {maxValue,7:#0.0e0}");
        }
    }
}