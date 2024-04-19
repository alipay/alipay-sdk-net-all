using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationOrderapplyCreateResponse.
    /// </summary>
    public class AlipayInsSceneApplicationOrderapplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("biz_flow_no")]
        public string BizFlowNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
