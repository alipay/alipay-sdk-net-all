using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDoSignInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentDoSignInfoDTO : AopObject
    {
        /// <summary>
        /// 预授权信息。不传表示当前订单不使用预授权及芝麻免押
        /// </summary>
        [XmlElement("fund_auth_freeze_info")]
        public RentSignFundAuthFreezeInfoDTO FundAuthFreezeInfo { get; set; }

        /// <summary>
        /// 租赁代扣信息。不传表示当前订单不使用代扣。
        /// </summary>
        [XmlElement("rent_deduct_info")]
        public RentSignDeductInfoDTO RentDeductInfo { get; set; }
    }
}
