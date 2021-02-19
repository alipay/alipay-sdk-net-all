using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServiceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmServiceInitializeModel : AopObject
    {
        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务图标url。支持 http(s) 链接。
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 服务编码。可在服务上架后，在服务市场上查询此信息。
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称。可在服务上架后，在服务市场上查询此信息。
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务订购二维码链接
        /// </summary>
        [XmlElement("service_order_url")]
        public string ServiceOrderUrl { get; set; }

        /// <summary>
        /// spi定义列表
        /// </summary>
        [XmlArray("spis")]
        [XmlArrayItem("isv_spi_definition")]
        public List<IsvSpiDefinition> Spis { get; set; }
    }
}
