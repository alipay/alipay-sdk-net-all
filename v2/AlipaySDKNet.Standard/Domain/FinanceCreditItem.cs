using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceCreditItem Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceCreditItem : AopObject
    {
        /// <summary>
        /// 授信id
        /// </summary>
        [XmlElement("credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// 版本，从1开始，0表示最新版本
        /// </summary>
        [XmlElement("ver")]
        public long Ver { get; set; }
    }
}
