using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 负责人名字
        /// </summary>
        [XmlElement("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 负责人工号
        /// </summary>
        [XmlElement("charge_no")]
        public string ChargeNo { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_address")]
        public string FileAddress { get; set; }

        /// <summary>
        /// 文件名字
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 参与人列表
        /// </summary>
        [XmlArray("participants")]
        [XmlArrayItem("string")]
        public List<string> Participants { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 模板库编码
        /// </summary>
        [XmlElement("template_lib_code")]
        public string TemplateLibCode { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
