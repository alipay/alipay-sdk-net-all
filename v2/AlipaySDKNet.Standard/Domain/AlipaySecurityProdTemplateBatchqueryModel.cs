using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 接口调用人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 来源系统名，可以是后端应用名字
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 模板状态，可以是enable和disable
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板编码集合，支持批量查询模板
        /// </summary>
        [XmlArray("template_codes")]
        [XmlArrayItem("string")]
        public List<string> TemplateCodes { get; set; }

        /// <summary>
        /// 模板所属的模板库编码
        /// </summary>
        [XmlElement("template_lib_code")]
        public string TemplateLibCode { get; set; }

        /// <summary>
        /// 模板名字，支持模糊匹配
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板中心租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
