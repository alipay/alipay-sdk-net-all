using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasFormtemplateQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasFormtemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// form_template_id + 唯一 + 页面表单模板查询 + 数据库。
        /// </summary>
        [XmlElement("form_template_id")]
        public string FormTemplateId { get; set; }

        /// <summary>
        /// form_template_json_string + 页面表单模板查询 + 数据库。
        /// </summary>
        [XmlElement("form_template_json_string")]
        public string FormTemplateJsonString { get; set; }

        /// <summary>
        /// form_template_name + 页面表单模板查询 + 数据库。
        /// </summary>
        [XmlElement("form_template_name")]
        public string FormTemplateName { get; set; }
    }
}
