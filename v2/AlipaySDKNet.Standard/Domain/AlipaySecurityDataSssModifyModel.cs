using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataSssModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataSssModifyModel : AopObject
    {
        /// <summary>
        /// 必须，复杂参数
        /// </summary>
        [XmlElement("fff")]
        public AgreementParams Fff { get; set; }

        /// <summary>
        /// 特殊可选，布尔值，有注意事项
        /// </summary>
        [XmlElement("fr")]
        public bool Fr { get; set; }

        /// <summary>
        /// 营业执照有效期时间，注意事项
        /// </summary>
        [XmlElement("license_expiry_date")]
        public string LicenseExpiryDate { get; set; }

        /// <summary>
        /// 数字，path，无注意事项
        /// </summary>
        [XmlElement("xxx")]
        public long Xxx { get; set; }

        /// <summary>
        /// 金额，string,示例值，枚举值，注意事项
        /// </summary>
        [XmlElement("xxx_amount")]
        public string XxxAmount { get; set; }
    }
}
