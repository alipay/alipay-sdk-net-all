using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantChargingRule Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantChargingRule : AopObject
    {
        /// <summary>
        /// 收费金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收费模式，参考枚举值
        /// </summary>
        [XmlElement("charging_mode")]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 支付宝主体信息
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }
    }
}
