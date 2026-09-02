using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PushChannelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PushChannelDTO : AopObject
    {
        /// <summary>
        /// 本次请求的业务id，业务方提供
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 推送类型
        /// </summary>
        [XmlElement("push_type")]
        public string PushType { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("template_params")]
        public string TemplateParams { get; set; }
    }
}
