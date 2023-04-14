using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FormTemplateRelationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FormTemplateRelationDTO : AopObject
    {
        /// <summary>
        /// form_template_id + 关联关系查询 + 数据库。
        /// </summary>
        [XmlElement("form_template_id")]
        public string FormTemplateId { get; set; }

        /// <summary>
        /// form_template_name + 关联关系查询 + 数据库。
        /// </summary>
        [XmlElement("form_template_name")]
        public string FormTemplateName { get; set; }

        /// <summary>
        /// gmt_create + 关联关系查询 + 数据库。
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// gmt_modified + 关联关系查询 + 数据库。
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// id + 唯一 + 关联关系查询 + 数据库。
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// marketing_type + 关联关系查询 + 数据库。
        /// </summary>
        [XmlElement("marketing_type")]
        public string MarketingType { get; set; }
    }
}
