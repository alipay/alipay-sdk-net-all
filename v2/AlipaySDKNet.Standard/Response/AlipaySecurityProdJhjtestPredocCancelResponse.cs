using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdJhjtestPredocCancelResponse.
    /// </summary>
    public class AlipaySecurityProdJhjtestPredocCancelResponse : AopResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// 基础描述
        /// </summary>
        [XmlElement("out_b")]
        public string OutB { get; set; }

        /// <summary>
        /// 修改子参数变成字段copy
        /// </summary>
        [XmlElement("out_com")]
        public JhjTestNew OutCom { get; set; }
    }
}
