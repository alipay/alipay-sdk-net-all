using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDigitalidentityHealthcardQueryResponse.
    /// </summary>
    public class AlipayUserDigitalidentityHealthcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 健康卡输出聚合信息
        /// </summary>
        [XmlElement("health_card_info")]
        public HealthCardInfo HealthCardInfo { get; set; }
    }
}
