using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryPromoParam Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryPromoParam : AopObject
    {
        /// <summary>
        /// 存在延迟扣款这一类的场景，用这个时间表明用户发生交易的时间，比如说，在公交地铁场景，用户刷码出站的时间，和商户上送交易的时间是不一样的。
        /// </summary>
        [XmlElement("actual_order_time")]
        public string ActualOrderTime { get; set; }
    }
}
