using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Solution Data Structure.
    /// </summary>
    [Serializable]
    public class Solution : AopObject
    {
        /// <summary>
        /// 设备预计处理天数，如果超时会重新进行派单
        /// </summary>
        [XmlArray("available_pause_days")]
        [XmlArrayItem("number")]
        public List<long> AvailablePauseDays { get; set; }

        /// <summary>
        /// 每个异常点都有固定对应的处理方案，在同步工单数据时，会将对应的可选处理方案Solution进行同步，用于对方在处理工单时选择对应的具体方案。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 对应处理方案描叙，在处理工单时，用于选择
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 不同的处理方案，要求是否一定必填处理意见，如果为true，则处理意见必填
        /// </summary>
        [XmlElement("need_notes")]
        public bool NeedNotes { get; set; }
    }
}
