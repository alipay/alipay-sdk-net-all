using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthPaymentNotifyResponse.
    /// </summary>
    public class AlipayFinancialnetAuthPaymentNotifyResponse : AopResponse
    {
        /// <summary>
        /// 响应结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 响应结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 业务结果是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
