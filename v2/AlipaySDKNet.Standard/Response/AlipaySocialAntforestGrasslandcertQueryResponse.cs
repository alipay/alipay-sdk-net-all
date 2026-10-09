using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestGrasslandcertQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestGrasslandcertQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("grassland_cert_detail_list")]
        [XmlArrayItem("grassland_cert_detail")]
        public List<GrasslandCertDetail> GrasslandCertDetailList { get; set; }

        /// <summary>
        /// true：有下一页 false：没有下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 下一页的游标
        /// </summary>
        [XmlElement("next_cursor")]
        public string NextCursor { get; set; }
    }
}
