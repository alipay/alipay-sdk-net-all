using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTasktemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务模板信息
        /// </summary>
        [XmlElement("task_template_info")]
        public TaoKeTaskTemplateInfoDTO TaskTemplateInfo { get; set; }
    }
}
