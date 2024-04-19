using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 页，默认1，必须要大于0。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，默认10。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 合同模板ID，如果存在则为唯一值，由系统生成，在保存成功后会返回该值。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 合同模板名称，非唯一值，由用户自行输入。
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
