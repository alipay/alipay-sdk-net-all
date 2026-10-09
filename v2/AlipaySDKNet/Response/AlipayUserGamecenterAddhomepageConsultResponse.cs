using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamecenterAddhomepageConsultResponse.
    /// </summary>
    public class AlipayUserGamecenterAddhomepageConsultResponse : AopResponse
    {
        /// <summary>
        /// Y：已添加首页，N：未添加首页
        /// </summary>
        [XmlElement("consult_result")]
        public string ConsultResult { get; set; }
    }
}
