using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountClearingcenterPayoffModifyModel : AopObject
    {
        /// <summary>
        /// 是否高优先级处理登记薄
        /// </summary>
        [XmlElement("is_high_priority")]
        public bool IsHighPriority { get; set; }

        /// <summary>
        /// 待解付资金流水号 唯一键
        /// </summary>
        [XmlElement("pay_off_no")]
        public string PayOffNo { get; set; }
    }
}
