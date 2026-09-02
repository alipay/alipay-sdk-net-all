using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePreconsultQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphonePreconsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 预咨询状态
        /// </summary>
        [XmlElement("consult_status")]
        public string ConsultStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("preconsult_result_list")]
        [XmlArrayItem("preconsult_result")]
        public List<PreconsultResult> PreconsultResultList { get; set; }

        /// <summary>
        /// 预鉴权请求流水号（全局唯一）
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
