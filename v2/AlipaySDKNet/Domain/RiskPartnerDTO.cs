using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskPartnerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskPartnerDTO : AopObject
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// ou编码
        /// </summary>
        [XmlElement("ou")]
        public string Ou { get; set; }
    }
}
