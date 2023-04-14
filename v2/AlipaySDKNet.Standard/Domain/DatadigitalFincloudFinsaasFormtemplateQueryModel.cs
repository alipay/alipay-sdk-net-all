using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasFormtemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasFormtemplateQueryModel : AopObject
    {
        /// <summary>
        /// form_template_id + 唯一 + 表单模板查询 + 批量查询接口会返回该值。
        /// </summary>
        [XmlElement("form_template_id")]
        public string FormTemplateId { get; set; }
    }
}
