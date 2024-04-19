using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTaskOperationCreateResponse.
    /// </summary>
    public class AlipayCommerceTaskOperationCreateResponse : AopResponse
    {
        /// <summary>
        /// 平台任务模版id
        /// </summary>
        [XmlElement("platform_template_id")]
        public string PlatformTemplateId { get; set; }

        /// <summary>
        /// 行业任务模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
