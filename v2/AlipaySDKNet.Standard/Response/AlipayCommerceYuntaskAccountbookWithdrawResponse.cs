using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskAccountbookWithdrawResponse.
    /// </summary>
    public class AlipayCommerceYuntaskAccountbookWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 处理成功金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
    }
}
