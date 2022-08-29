using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeductInfo : AopObject
    {
        /// <summary>
        /// 自定义优惠规则
        /// </summary>
        [XmlElement("customer_define_deduct_rule")]
        public CustomerDefineDeductRule CustomerDefineDeductRule { get; set; }
    }
}
