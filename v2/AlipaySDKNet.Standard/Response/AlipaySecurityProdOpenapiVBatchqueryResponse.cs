using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdOpenapiVBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdOpenapiVBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 可选
        /// </summary>
        [XmlElement("cde")]
        public string Cde { get; set; }

        /// <summary>
        /// 特殊可选
        /// </summary>
        [XmlElement("ds")]
        public CedsipeihuanCcomplex Ds { get; set; }
    }
}
