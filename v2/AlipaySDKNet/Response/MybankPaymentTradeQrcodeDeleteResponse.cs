using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeQrcodeDeleteResponse.
    /// </summary>
    public class MybankPaymentTradeQrcodeDeleteResponse : AopResponse
    {
        /// <summary>
        /// true:失效成功 false:失效失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
