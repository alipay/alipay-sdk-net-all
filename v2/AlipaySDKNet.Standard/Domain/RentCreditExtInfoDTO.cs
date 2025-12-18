using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCreditExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentCreditExtInfoDTO : AopObject
    {
        /// <summary>
        /// 纯代扣签约场景该订单是否使用租安盾风控。不传默认不使用
        /// </summary>
        [XmlElement("fee_risk_model")]
        public string FeeRiskModel { get; set; }

        /// <summary>
        /// 对应芝麻免押风控进阶参数freezeFlagRentOnline
        /// </summary>
        [XmlElement("freeze_flag_rent_online")]
        public string FreezeFlagRentOnline { get; set; }

        /// <summary>
        /// 对应芝麻免押风控进阶参数preRiskFlagRentOnline
        /// </summary>
        [XmlElement("pre_risk_flag_rent_online")]
        public string PreRiskFlagRentOnline { get; set; }
    }
}
