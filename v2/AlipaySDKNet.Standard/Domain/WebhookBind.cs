using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WebhookBind Data Structure.
    /// </summary>
    [Serializable]
    public class WebhookBind : AopObject
    {
        /// <summary>
        /// 绑定ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 绑定名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 请求对象
        /// </summary>
        [XmlElement("request_body")]
        public string RequestBody { get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        [XmlElement("request_headers")]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        [XmlElement("request_url")]
        public string RequestUrl { get; set; }
    }
}
