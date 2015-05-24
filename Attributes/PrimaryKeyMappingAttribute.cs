using System;

namespace EnterpriseDAAB
{
    [AttributeUsageAttribute(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class PrimaryKeyMappingAttribute : BaseMappingAttribute
    {
        /// <summary>
        /// 是否為自動遞增
        /// </summary>
        public bool IsAutoIncrement { get; set; }
    }
}