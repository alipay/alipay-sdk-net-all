using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MdRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MdRecord : AopObject
    {
        /// <summary>
        /// 主数据的结构类型 如：网状类型（NETWORK）
        /// </summary>
        [XmlElement("data_struct")]
        public string DataStruct { get; set; }

        /// <summary>
        /// 主数据项名
        /// </summary>
        [XmlElement("dicode")]
        public string Dicode { get; set; }

        /// <summary>
        /// 主数据项的中文名称
        /// </summary>
        [XmlElement("diname")]
        public string Diname { get; set; }

        /// <summary>
        /// 记录动态字段的键值对
        /// </summary>
        [XmlArray("dynamic_fields")]
        [XmlArrayItem("fv_pair_list")]
        public List<FvPairList> DynamicFields { get; set; }

        /// <summary>
        /// 数据条目的更改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 数据条目的id值
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 父亲节点的id列表，网状结构可能有多个父亲节点
        /// </summary>
        [XmlArray("multi_parents")]
        [XmlArrayItem("string")]
        public List<string> MultiParents { get; set; }
    }
}
