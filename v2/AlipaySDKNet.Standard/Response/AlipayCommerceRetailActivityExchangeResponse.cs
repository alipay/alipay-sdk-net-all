using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailActivityExchangeResponse.
    /// </summary>
    public class AlipayCommerceRetailActivityExchangeResponse : AopResponse
    {
        /// <summary>
        /// 积分兑换状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
