using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskDetailGetResponse.
    /// </summary>
    public class AlipayCommerceYuntaskDetailGetResponse : AopResponse
    {
        /// <summary>
        /// 任务详情
        /// </summary>
        [XmlElement("task")]
        public YunTaskTemplateInfoDTO Task { get; set; }
    }
}
