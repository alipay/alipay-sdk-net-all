using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceBankaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceBankaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 开设账户的银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 仅当 status 为 FAIL 时该字段有值。其他状态下该字段为空或不返回。
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户的签约名称或营业执照名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID (Partner ID)
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 开户状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
