using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthAmountDTO : AopObject
    {
        /// <summary>
        /// 单位为：分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// ORDER_AMOUNT单笔金额 TOTAL_AMOUNT累计金额
        /// </summary>
        [XmlElement("auth_factor")]
        public string AuthFactor { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
    }
}
