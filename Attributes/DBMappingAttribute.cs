using System;

namespace EnterpriseDAAB
{
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class DBMappingAttribute : BaseMappingAttribute
    {
    }
}