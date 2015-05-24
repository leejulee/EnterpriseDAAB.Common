using System;

namespace EnterpriseDAAB
{
    public abstract class BaseMappingAttribute : Attribute
    {
        public string Name { get; set; }
    }
}