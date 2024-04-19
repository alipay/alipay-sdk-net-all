using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CashBackInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CashBackInfoDTO : AopObject
    {
        /// <summary>
        /// 返还金额
        /// </summary>
        [XmlElement("amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("origin_amount")]
        public Amount OriginAmount { get; set; }
    }
}
