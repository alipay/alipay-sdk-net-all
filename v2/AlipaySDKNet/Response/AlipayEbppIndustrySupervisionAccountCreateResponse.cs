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
        /// 商户子户账号
        /// </summary>
        [XmlElement("merchant_account_no")]
        public string MerchantAccountNo { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        [XmlElement("merchant_account_status")]
        public string MerchantAccountStatus { get; set; }
    }
}
