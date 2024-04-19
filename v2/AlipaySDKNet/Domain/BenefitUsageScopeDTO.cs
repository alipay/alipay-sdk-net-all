using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitUsageScopeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitUsageScopeDTO : AopObject
    {
        /// <summary>
        /// 使用范围描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// ALL ： 全场通用;CATEGORY ： 指定品类可用;ITEM ： 指定单品可用
        /// </summary>
        [XmlElement("usage_scope_type")]
        public string UsageScopeType { get; set; }
    }
}
