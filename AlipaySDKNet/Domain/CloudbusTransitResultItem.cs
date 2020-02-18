using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudbusTransitResultItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusTransitResultItem : AopObject
    {
        /// <summary>
        /// 接口状态码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 公交客流走廊列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("cloudbus_transit_item")]
        public List<CloudbusTransitItem> Data { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
