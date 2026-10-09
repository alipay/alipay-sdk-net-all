using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasFormtemplateRelationsBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasFormtemplateRelationsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// form_template_relations + 关联关系查询 + 数据库。
        /// </summary>
        [XmlArray("form_template_relations")]
        [XmlArrayItem("form_template_relation_d_t_o")]
        public List<FormTemplateRelationDTO> FormTemplateRelations { get; set; }

        /// <summary>
        /// total + 关联关系查询 + 数据库
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
