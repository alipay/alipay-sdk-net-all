using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagRuleItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TagRuleItemDTO : AopObject
    {
        /// <summary>
        /// 字段类型+不唯一
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 标签取值+不唯一
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("tag_dist_d_t_o")]
        public List<TagDistDTO> Datas { get; set; }

        /// <summary>
        /// 场景code+唯一
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 展示方式+不唯一
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 存储类型+不唯一
        /// </summary>
        [XmlElement("store_type")]
        public string StoreType { get; set; }

        /// <summary>
        /// 标签code+唯一
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签名称+不唯一
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签类型+不唯一
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }
    }
}
