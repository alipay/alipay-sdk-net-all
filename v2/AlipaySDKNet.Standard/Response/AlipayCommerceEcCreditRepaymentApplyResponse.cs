using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditRepaymentApplyResponse.
    /// </summary>
    public class AlipayCommerceEcCreditRepaymentApplyResponse : AopResponse
    {
        /// <summary>
        /// 还款免登链接，资方根据token生成登录态
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
