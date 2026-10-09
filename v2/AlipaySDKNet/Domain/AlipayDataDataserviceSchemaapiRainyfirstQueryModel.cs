using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapiRainyfirstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapiRainyfirstQueryModel : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("string_tc_01")]
        public string StringTc01 { get; set; }
    }
}
