using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppDanielQueryResponse.
    /// </summary>
    public class AlipayOpenAppDanielQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("daniel_out_complex")]
        public AppTestInfo DanielOutComplex { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("daniel_out_price")]
        public string DanielOutPrice { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("daniel_output")]
        public string DanielOutput { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("output_boolean")]
        public bool OutputBoolean { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("output_date")]
        public string OutputDate { get; set; }
    }
}
