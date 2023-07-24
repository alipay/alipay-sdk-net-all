using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountInfoQueryResponse.
    /// </summary>
    public class AlipayFundAccountInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否允许余额支付
        /// </summary>
        [XmlElement("enable_payment")]
        public bool EnablePayment { get; set; }
    }
}
