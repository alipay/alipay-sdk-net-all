using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineTextQc Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineTextQc : AopObject
    {
        /// <summary>
        /// 热线可以选择传递的号码
        /// </summary>
        [XmlElement("caller_phone")]
        public string CallerPhone { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 对话内容
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("qc_dialog")]
        public List<QcDialog> Content { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [XmlElement("incoming_time")]
        public string IncomingTime { get; set; }

        /// <summary>
        /// 对话轮次
        /// </summary>
        [XmlElement("rounds")]
        public long Rounds { get; set; }
    }
}
