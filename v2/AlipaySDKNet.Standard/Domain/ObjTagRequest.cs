using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjTagRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObjTagRequest : AopObject
    {
        /// <summary>
        /// 股票代码列表，限制条数100个以内
        /// </summary>
        [XmlArray("obj_ids")]
        [XmlArrayItem("string")]
        public List<string> ObjIds { get; set; }

        /// <summary>
        /// 标的类型列表，可以为空
        /// </summary>
        [XmlArray("obj_types")]
        [XmlArrayItem("string")]
        public List<string> ObjTypes { get; set; }

        /// <summary>
        /// 标签代码列表，不能为空
        /// </summary>
        [XmlArray("tag_codes")]
        [XmlArrayItem("string")]
        public List<string> TagCodes { get; set; }

        /// <summary>
        /// 标签分组，可以为空
        /// </summary>
        [XmlArray("tag_groups")]
        [XmlArrayItem("string")]
        public List<string> TagGroups { get; set; }
    }
}
