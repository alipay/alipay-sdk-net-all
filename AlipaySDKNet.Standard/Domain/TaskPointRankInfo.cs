using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskPointRankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskPointRankInfo : AopObject
    {
        /// <summary>
        /// 距离前一名积分差距
        /// </summary>
        [XmlElement("difference")]
        public long Difference { get; set; }

        /// <summary>
        /// 当前排名
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 排名类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
