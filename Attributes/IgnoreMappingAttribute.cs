using System;

namespace EnterpriseDAAB
{
    [AttributeUsageAttribute(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class IgnoreMappingAttribute : BaseMappingAttribute
    {
    }
}