using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBpaasPushSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBpaasPushSyncModel : AopObject
    {
        /// <summary>
        /// bpaas应用ID
        /// </summary>
        [XmlElement("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [XmlElement("bpaas_app_version")]
        public string BpaasAppVersion { get; set; }

        /// <summary>
        /// 设备SN，支持同一个厂商的SN批量反馈；数组限制最大100
        /// </summary>
        [XmlArray("device_sn")]
        [XmlArrayItem("string")]
        public List<string> DeviceSn { get; set; }

        /// <summary>
        /// 厂商ID，需要和设备端的生产商ID保持一致
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
