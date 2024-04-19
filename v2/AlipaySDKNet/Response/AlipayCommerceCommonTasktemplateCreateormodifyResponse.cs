using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateCreateormodifyResponse.
    /// </summary>
    public class AlipayCommerceCommonTasktemplateCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
