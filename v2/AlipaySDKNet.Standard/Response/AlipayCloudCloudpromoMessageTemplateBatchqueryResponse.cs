using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页码。默认取值为1。
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页展示的模板个数。取值范围：1~100。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 模板列表
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("sms_template_detail")]
        public List<SmsTemplateDetail> TemplateList { get; set; }

        /// <summary>
        /// 模板总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
