using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipaySubscribeTimesSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipaySubscribeTimesSaveModel : AopObject
    {
        /// <summary>
        /// 计次时的渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用来作为幂等值传入
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订购计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 消耗次数
        /// </summary>
        [XmlElement("use_times")]
        public long UseTimes { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
