using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdJhjtestRegressionQueryResponse.
    /// </summary>
    public class AlipaySecurityProdJhjtestRegressionQueryResponse : AopResponse
    {
        /// <summary>
        /// 22
        /// </summary>
        [XmlElement("comp_c")]
        public PubNestPub CompC { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("comp_d")]
        public DomainNestOther CompD { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("out_a")]
        public RegressionPublic OutA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("out_comp_b")]
        public RegressionInDomian OutCompB { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("out_para")]
        public string OutPara { get; set; }
    }
}
