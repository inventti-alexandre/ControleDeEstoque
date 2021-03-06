﻿using System.ComponentModel;
using SQFramework.Core.Enums;

namespace ControleDeEstoque.Common
{
    [TypeConverter(typeof(EnumConverter<EnumExample>))]
    public enum EnumExample
    {
        [StringValue("0", "Undefined", false)]
        Undefined = 0,
        [StringValue("1", "Example 1")]
        Example1 = 1,
        [StringValue("2", "Example 2")]
        Example2 = 2
    }
}