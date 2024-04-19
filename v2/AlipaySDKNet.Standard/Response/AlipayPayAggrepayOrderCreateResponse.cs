using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAggrepayOrderCreateResponse.
    /// </summary>
    public class AlipayPayAggrepayOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 微信支付参数相关信息
        /// </summary>
        [XmlElement("pay_data")]
        public string PayData { get; set; }
    }
}
