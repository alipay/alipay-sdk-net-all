using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateElementLinkDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateElementLinkDTO : AopObject
    {
        /// <summary>
        /// 组件内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建人名字
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("creator_no")]
        public string CreatorNo { get; set; }

        /// <summary>
        /// 组件编码
        /// </summary>
        [XmlElement("element_code")]
        public string ElementCode { get; set; }

        /// <summary>
        /// 组件展示名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组件排行
        /// </summary>
        [XmlElement("sort_value")]
        public long SortValue { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 组件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 组件唯一标识
        /// </summary>
        [XmlElement("uk")]
        public string Uk { get; set; }
    }
}
