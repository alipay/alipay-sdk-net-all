using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditPayConsultResponse.
    /// </summary>
    public class AlipayTradeCreditPayConsultResponse : AopResponse
    {
        /// <summary>
        /// 准入咨询结果AVAILABLE：可用；UNAVAILABLE：不可用。
        /// </summary>
        [XmlElement("consult_result")]
        public string ConsultResult { get; set; }
    }
}
