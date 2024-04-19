using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderInstantdeliveryCancelResponse.
    /// </summary>
    public class AlipayCommerceLogisticsOrderInstantdeliveryCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消金额
        /// </summary>
        [XmlElement("cancel_fee")]
        public string CancelFee { get; set; }
    }
}
