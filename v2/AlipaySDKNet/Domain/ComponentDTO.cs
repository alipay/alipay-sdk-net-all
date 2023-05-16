using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComponentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ComponentDTO : AopObject
    {
        /// <summary>
        /// 可修改
        /// </summary>
        [XmlElement("enable_edit")]
        public string EnableEdit { get; set; }

        /// <summary>
        /// 表达式
        /// </summary>
        [XmlElement("exp")]
        public string Exp { get; set; }

        /// <summary>
        /// 返回类型
        /// </summary>
        [XmlElement("exp_return_type")]
        public string ExpReturnType { get; set; }

        /// <summary>
        /// 组件id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// placeholder
        /// </summary>
        [XmlElement("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// readonly
        /// </summary>
        [XmlElement("readonly")]
        public string Readonly { get; set; }

        /// <summary>
        /// ref
        /// </summary>
        [XmlElement("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// required
        /// </summary>
        [XmlElement("required")]
        public string Required { get; set; }

        /// <summary>
        /// size
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlElement("src_content")]
        public string SrcContent { get; set; }

        /// <summary>
        /// 结构化要素渲染的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 唯一key
        /// </summary>
        [XmlElement("uk")]
        public string Uk { get; set; }

        /// <summary>
        /// 组件值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
