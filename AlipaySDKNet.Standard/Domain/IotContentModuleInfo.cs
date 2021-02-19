using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotContentModuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotContentModuleInfo : AopObject
    {
        /// <summary>
        /// 对展位内容加签，用于校验内容合法性
        /// </summary>
        [XmlElement("content_sign")]
        public string ContentSign { get; set; }

        /// <summary>
        /// 展位详情加密后返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 权益标识
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 展位类型，如BusinessOperation，CdpOperation
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// H5页面链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
