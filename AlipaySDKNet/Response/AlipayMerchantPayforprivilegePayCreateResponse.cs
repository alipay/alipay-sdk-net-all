using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePayCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePayCreateResponse : AopResponse
    {
        /// <summary>
        /// 用于唤起资金授权支付的orderStr参数
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }
    }
}
