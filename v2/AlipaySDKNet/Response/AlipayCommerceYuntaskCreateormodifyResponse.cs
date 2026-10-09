using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskCreateormodifyResponse.
    /// </summary>
    public class AlipayCommerceYuntaskCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 调用成功返回任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
