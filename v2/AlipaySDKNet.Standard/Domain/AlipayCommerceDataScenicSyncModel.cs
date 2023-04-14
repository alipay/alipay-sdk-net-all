using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataScenicSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataScenicSyncModel : AopObject
    {
        /// <summary>
        /// 码值信息
        /// </summary>
        [XmlArray("code_value")]
        [XmlArrayItem("string")]
        public List<string> CodeValue { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 服务商维护的景区地址
        /// </summary>
        [XmlElement("isv_scenic_address")]
        public string IsvScenicAddress { get; set; }

        /// <summary>
        /// 服务商维护的景区名称
        /// </summary>
        [XmlElement("isv_scenic_name")]
        public string IsvScenicName { get; set; }

        /// <summary>
        /// 服务商内部每个景区的唯一ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 服务商负责的景区小程序APPID
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 支付宝景区ID
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }
    }
}
