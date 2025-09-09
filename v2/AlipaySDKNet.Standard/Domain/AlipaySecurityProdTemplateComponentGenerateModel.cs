using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateComponentGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateComponentGenerateModel : AopObject
    {
        /// <summary>
        /// 组件分类
        /// </summary>
        [XmlElement("component_category")]
        public string ComponentCategory { get; set; }

        /// <summary>
        /// 组件类型
        /// </summary>
        [XmlElement("component_type")]
        public string ComponentType { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 是否可编辑
        /// </summary>
        [XmlElement("enable_edit")]
        public bool EnableEdit { get; set; }

        /// <summary>
        /// 组件占位符
        /// </summary>
        [XmlElement("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

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
    }
}
