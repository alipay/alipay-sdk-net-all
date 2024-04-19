using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 展示第几页的模板信息。默认取值为1。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页展示的模板个数，取值范围：1~100。默认值为10。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 模板code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
