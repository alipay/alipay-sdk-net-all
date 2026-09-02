using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShipAssessmentRes Data Structure.
    /// </summary>
    [Serializable]
    public class ShipAssessmentRes : AopObject
    {
        /// <summary>
        /// D是商家在租安盾后台创建并获取
        /// </summary>
        [XmlElement("risk_scheme_id")]
        public string RiskSchemeId { get; set; }
    }
}
