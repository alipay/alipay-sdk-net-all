using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalkPathMetaData Data Structure.
    /// </summary>
    [Serializable]
    public class WalkPathMetaData : AopObject
    {
        /// <summary>
        /// 路线场景码
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 路线id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 路线距离文案(公里)，不影响实际计算 当前字段已废弃(不能表达浮点数路线长度)
        /// </summary>
        [XmlElement("path_length")]
        public long PathLength { get; set; }

        /// <summary>
        /// 路线总步数
        /// </summary>
        [XmlElement("path_step_count")]
        public long PathStepCount { get; set; }

        /// <summary>
        /// 路线距离文案(公里)，不影响实际计算
        /// </summary>
        [XmlElement("str_path_length")]
        public string StrPathLength { get; set; }

        /// <summary>
        /// 路线名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
