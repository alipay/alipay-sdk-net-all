using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateInstanceInitializeModel : AopObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("biz_business_id")]
        public string BizBusinessId { get; set; }

        /// <summary>
        /// 业务参数对象，用来填充模板
        /// </summary>
        [XmlElement("biz_object_def_json")]
        public string BizObjectDefJson { get; set; }

        /// <summary>
        /// 非必填内容，不传时，以businessId作为幂等键
        /// </summary>
        [XmlElement("idempotent")]
        public string Idempotent { get; set; }

        /// <summary>
        /// 是否需要doc文件结果
        /// </summary>
        [XmlElement("need_file")]
        public bool NeedFile { get; set; }

        /// <summary>
        /// 是否需要结果生成html文件
        /// </summary>
        [XmlElement("need_html")]
        public bool NeedHtml { get; set; }

        /// <summary>
        /// 系统来源Id
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlArray("template_codes")]
        [XmlArrayItem("string")]
        public List<string> TemplateCodes { get; set; }

        /// <summary>
        /// 模板库编码，需要找owner获取自己业务系统模板库的编码
        /// </summary>
        [XmlElement("template_lib_code")]
        public string TemplateLibCode { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
