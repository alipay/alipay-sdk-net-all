using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestGrasslandexchangeApplyResponse.
    /// </summary>
    public class AlipaySocialAntforestGrasslandexchangeApplyResponse : AopResponse
    {
        /// <summary>
        /// true幂等 false不幂等
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }

        /// <summary>
        /// 当次兑换获得的证书信息
        /// </summary>
        [XmlElement("user_grassland_certificate")]
        public GrasslandCert UserGrasslandCertificate { get; set; }
    }
}
