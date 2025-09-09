using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypeTheEleven Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypeTheEleven : AopObject
    {
        /// <summary>
        /// Hu昂天
        /// </summary>
        [XmlElement("tc_01")]
        public string Tc01 { get; set; }
    }
}
