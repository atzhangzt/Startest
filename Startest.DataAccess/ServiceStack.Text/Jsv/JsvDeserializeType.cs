﻿using ServiceStack.Text.Common;
using System;
using System.Reflection;

namespace ServiceStack.Text.Jsv
{
    public static class JsvDeserializeType
    {
        public static SetPropertyDelegate GetSetPropertyMethod(Type type, PropertyInfo propertyInfo)
        {
            return TypeAccessor.GetSetPropertyMethod(type, propertyInfo);
        }

        public static SetPropertyDelegate GetSetFieldMethod(Type type, FieldInfo fieldInfo)
        {
            return TypeAccessor.GetSetFieldMethod(type, fieldInfo);
        }
    }
}