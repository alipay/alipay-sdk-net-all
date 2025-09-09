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
        /// 积分兑换结果，true为成功，false为失败
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
