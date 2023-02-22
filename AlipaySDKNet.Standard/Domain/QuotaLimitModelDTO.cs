using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaLimitModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaLimitModelDTO : AopObject
    {
        /// <summary>
        /// AMOUNT_LIMIT，金额限制
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 当type=AMOUNT_LIMIT时，传入格式[100,+∞)
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
