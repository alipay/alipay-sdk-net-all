using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSchematoapioneRainystestSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSchematoapioneRainystestSyncModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("demo_open_id")]
        public string DemoOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesRefWeakFirst DemoRef { get; set; }
    }
}
