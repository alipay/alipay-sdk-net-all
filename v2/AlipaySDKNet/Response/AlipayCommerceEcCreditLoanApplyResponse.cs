using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditLoanApplyResponse.
    /// </summary>
    public class AlipayCommerceEcCreditLoanApplyResponse : AopResponse
    {
        /// <summary>
        /// 银行授信借款操作页面地址
        /// </summary>
        [XmlElement("apply_url")]
        public string ApplyUrl { get; set; }
    }
}
