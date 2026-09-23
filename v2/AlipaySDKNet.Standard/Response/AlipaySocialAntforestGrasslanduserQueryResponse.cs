using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestGrasslanduserQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestGrasslanduserQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通 true
        /// </summary>
        [XmlElement("open_status")]
        public bool OpenStatus { get; set; }

        /// <summary>
        /// 神奇草原证书数量
        /// </summary>
        [XmlElement("total_grassland_cert_num")]
        public long TotalGrasslandCertNum { get; set; }
    }
}
