using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 合同模板ID，如果存在则为唯一值，由系统生成，在保存成功后会返回该值。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
