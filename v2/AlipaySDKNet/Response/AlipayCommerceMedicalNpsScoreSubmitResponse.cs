using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalNpsScoreSubmitResponse.
    /// </summary>
    public class AlipayCommerceMedicalNpsScoreSubmitResponse : AopResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("deal_info")]
        public bool DealInfo { get; set; }
    }
}
