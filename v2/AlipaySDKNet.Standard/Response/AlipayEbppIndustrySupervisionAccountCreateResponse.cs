using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountCreateResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 基于请求参数创建的子户账户户号
        /// </summary>
        [XmlElement("merchant_account_no")]
        public string MerchantAccountNo { get; set; }

        /// <summary>
        /// 子户账户状态
        /// </summary>
        [XmlElement("merchant_account_status")]
        public string MerchantAccountStatus { get; set; }
    }
}
