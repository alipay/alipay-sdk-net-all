using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DynamicAwardConfigDataDto Data Structure.
    /// </summary>
    [Serializable]
    public class DynamicAwardConfigDataDto : AopObject
    {
        /// <summary>
        /// 计数限制
        /// </summary>
        [XmlElement("count_limit")]
        public long CountLimit { get; set; }

        /// <summary>
        /// 额外动态奖励值
        /// </summary>
        [XmlElement("dynamic_award_count")]
        public long DynamicAwardCount { get; set; }
    }
}
