using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateVersionQueryModel : AopObject
    {
        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 是否需要pdf文件
        /// </summary>
        [XmlElement("need_pdf")]
        public bool NeedPdf { get; set; }

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
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
