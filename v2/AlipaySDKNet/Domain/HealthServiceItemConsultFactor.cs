using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthServiceItemConsultFactor Data Structure.
    /// </summary>
    [Serializable]
    public class HealthServiceItemConsultFactor : AopObject
    {
        /// <summary>
        /// 咨询因子Key
        /// </summary>
        [XmlElement("factor_key")]
        public string FactorKey { get; set; }

        /// <summary>
        /// 咨询因子值
        /// </summary>
        [XmlElement("factor_value")]
        public string FactorValue { get; set; }
    }
}
