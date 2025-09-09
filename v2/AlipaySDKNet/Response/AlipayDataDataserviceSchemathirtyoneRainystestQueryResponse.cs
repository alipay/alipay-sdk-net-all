using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemathirtyoneRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemathirtyoneRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// test case
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// test CASE FOR PRE
        /// </summary>
        [XmlElement("demo_empty_vv")]
        public string DemoEmptyVv { get; set; }

        /// <summary>
        /// test case change the value
        /// </summary>
        [XmlElement("demo_emtpy")]
        public string DemoEmtpy { get; set; }

        /// <summary>
        /// test case change the empty
        /// </summary>
        [XmlElement("demo_other")]
        public string DemoOther { get; set; }

        /// <summary>
        /// test case
        /// </summary>
        [XmlElement("demo_weak_ref")]
        public RainysCompelxTypeWeakRefTwo DemoWeakRef { get; set; }

        /// <summary>
        /// 出参一
        /// </summary>
        [XmlElement("outone")]
        public RainyComplexTypesTheFourteen Outone { get; set; }
    }
}
