using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额（单位分）
        /// </summary>
        [XmlElement("account_balance")]
        public long AccountBalance { get; set; }

        /// <summary>
        /// 子户账户户号
        /// </summary>
        [XmlElement("masking_account_no")]
        public string MaskingAccountNo { get; set; }

        /// <summary>
        /// 账户状态 可用、冻结
        /// </summary>
        [XmlElement("merchant_account_status")]
        public string MerchantAccountStatus { get; set; }
    }
}
