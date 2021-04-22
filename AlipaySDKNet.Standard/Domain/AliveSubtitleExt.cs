using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliveSubtitleExt Data Structure.
    /// </summary>
    [Serializable]
    public class AliveSubtitleExt : AopObject
    {
        /// <summary>
        /// 当前句子识别结果的置信度，取值范围：[0.0,1.0]。值越大表示置信度越高
        /// </summary>
        [XmlElement("confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// 句子截止时间，单位为ms
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 句子编号，从1开始递增（asr规则）。
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 句子超始时间，单位为ms
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 长句拆为短句后，长句中索引，从0开始
        /// </summary>
        [XmlElement("sub_index")]
        public long SubIndex { get; set; }
    }
}
