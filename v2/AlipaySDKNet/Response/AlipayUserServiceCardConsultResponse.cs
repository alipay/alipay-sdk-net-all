using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserServiceCardConsultResponse.
    /// </summary>
    public class AlipayUserServiceCardConsultResponse : AopResponse
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 卡片失效时间，如果长期有效，则为kong
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceList { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 卡片下的服务地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 占位符id
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
