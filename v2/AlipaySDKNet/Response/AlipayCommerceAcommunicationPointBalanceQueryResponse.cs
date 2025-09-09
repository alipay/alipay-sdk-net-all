using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointBalanceQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationPointBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户剩余积分，单位为个
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 当月过期积分数，单位为个
        /// </summary>
        [XmlElement("to_expired_point")]
        public long ToExpiredPoint { get; set; }
    }
}
