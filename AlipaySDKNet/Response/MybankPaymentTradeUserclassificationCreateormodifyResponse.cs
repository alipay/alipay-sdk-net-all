using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyResponse.
    /// </summary>
    public class MybankPaymentTradeUserclassificationCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 打标结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
