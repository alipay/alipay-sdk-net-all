using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsActivityAccessConsultResponse.
    /// </summary>
    public class AlipayCommerceLogisticsActivityAccessConsultResponse : AopResponse
    {
        /// <summary>
        /// true表示可参加活动，false表示不可参加活动
        /// </summary>
        [XmlElement("consult_result")]
        public bool ConsultResult { get; set; }
    }
}
