using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KmsBakingCheckDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KmsBakingCheckDTO : AopObject
    {
        /// <summary>
        /// 回传结束时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 回传起始时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 回传数量
        /// </summary>
        [XmlElement("sync_count")]
        public string SyncCount { get; set; }

        /// <summary>
        /// 回传日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("sync_time")]
        public string SyncTime { get; set; }
    }
}
