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
        /// lowerLimit（金额门槛）必填，upperLimit（金额上限） 如果无上限，upperLimit可不填
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
