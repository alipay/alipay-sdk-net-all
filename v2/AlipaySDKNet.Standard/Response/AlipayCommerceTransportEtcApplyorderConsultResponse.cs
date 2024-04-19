using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderConsultResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcApplyorderConsultResponse : AopResponse
    {
        /// <summary>
        /// 用户有未完成的行程，不能注销，结合consult_result判断
        /// </summary>
        [XmlElement("consult_desc")]
        public string ConsultDesc { get; set; }

        /// <summary>
        /// 注销咨询-可以注销
        /// </summary>
        [XmlElement("consult_result")]
        public bool ConsultResult { get; set; }

        /// <summary>
        /// 注销咨询
        /// </summary>
        [XmlElement("consult_scene")]
        public string ConsultScene { get; set; }
    }
}
