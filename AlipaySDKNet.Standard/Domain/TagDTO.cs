using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TagDTO : AopObject
    {
        /// <summary>
        /// 类目ID+唯一
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 类目名+不唯一
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 字段类型+不唯一
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 场景CODE+不唯一
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 显示方式+不唯一
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 存储类型+不唯一
        /// </summary>
        [XmlElement("store_type")]
        public string StoreType { get; set; }

        /// <summary>
        /// 标签逻辑层编码+唯一
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签描述+不唯一
        /// </summary>
        [XmlElement("tag_desc")]
        public string TagDesc { get; set; }

        /// <summary>
        /// 标签种类+不唯一
        /// </summary>
        [XmlElement("tag_kind")]
        public string TagKind { get; set; }

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
