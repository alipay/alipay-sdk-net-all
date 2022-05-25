using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletBalanceQueryResponse.
    /// </summary>
    public class AntMerchantMemberwalletBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 钱包账户余额（单位：元）
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 钱包账户膨胀金余额（单位：元）
        /// </summary>
        [XmlElement("benefit_balance")]
        public string BenefitBalance { get; set; }

        /// <summary>
        /// 钱包账户本金余额（单位：元）
        /// </summary>
        [XmlElement("principal_balance")]
        public string PrincipalBalance { get; set; }
    }
}
