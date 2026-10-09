using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSignInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentSignInfoDTO : AopObject
    {
        /// <summary>
        /// 信用产品信息。选了“预授权、租赁代扣”之一时必传，当前暂不支持单独使用
        /// </summary>
        [XmlElement("credit_info")]
        public RentCreditInfoDTO CreditInfo { get; set; }

        /// <summary>
        /// 预授权信息。不传表示当前订单不使用预授权及芝麻免押
        /// </summary>
        [XmlElement("fund_auth_freeze_info")]
        public RentFundAuthFreezeInfoDTO FundAuthFreezeInfo { get; set; }

        /// <summary>
        /// 租赁代扣信息。不传表示当前订单不使用代扣
        /// </summary>
        [XmlElement("rent_deduct_info")]
        public RentDeductInfoDTO RentDeductInfo { get; set; }
    }
}
