using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditIsvfrozenQueryResponse.
    /// </summary>
    public class AlipayCommerceEcCreditIsvfrozenQueryResponse : AopResponse
    {
        /// <summary>
        /// 已冻结金额，单位元，精确到分
        /// </summary>
        [XmlElement("frozen_amount")]
        public string FrozenAmount { get; set; }

        /// <summary>
        /// 冻结时间，精确到秒
        /// </summary>
        [XmlElement("frozen_time")]
        public string FrozenTime { get; set; }

        /// <summary>
        /// 冻结状态，FROZEN-冻结中、CLOSED-已关单（冻结额度已全额请款或者解冻都会触发关单）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
