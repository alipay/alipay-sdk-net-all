using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateAnswerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateAnswerQueryModel : AopObject
    {
        /// <summary>
        /// 业务要素
        /// </summary>
        [XmlElement("biz_object_def_json")]
        public string BizObjectDefJson { get; set; }

        /// <summary>
        /// 模版编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
