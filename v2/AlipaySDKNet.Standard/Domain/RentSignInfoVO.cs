using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSignInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentSignInfoVO : AopObject
    {
        /// <summary>
        /// 信用产品信息
        /// </summary>
        [XmlElement("credit_info")]
        public RentCreditInfoVO CreditInfo { get; set; }

        /// <summary>
        /// 预授权信息
        /// </summary>
        [XmlElement("fund_auth_freeze_info")]
        public RentFundAuthFreezeInfoVO FundAuthFreezeInfo { get; set; }

        /// <summary>
        /// 租赁代扣信息
        /// </summary>
        [XmlElement("rent_deduct_info")]
        public RentDeductInfoVO RentDeductInfo { get; set; }
    }
}
