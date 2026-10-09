using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundCardGenerateOrder Data Structure.
    /// </summary>
    [Serializable]
    public class FundCardGenerateOrder : AopObject
    {
        /// <summary>
        /// 卡面额，单位：元
        /// </summary>
        [XmlElement("denomination")]
        public long Denomination { get; set; }

        /// <summary>
        /// 过期日期(在此日期之后即过期，为null时则无过期日期)
        /// </summary>
        [XmlElement("expiration_date")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// 卡数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
