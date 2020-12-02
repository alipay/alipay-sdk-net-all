using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitSendResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitSendResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 发放单ID
        /// </summary>
        [XmlElement("send_id")]
        public string SendId { get; set; }

        /// <summary>
        /// 发放单状态，I:表示发放中、N:表示发放失败(属于重试也无法成功,比如预算不足等)、Y:表示发放成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
