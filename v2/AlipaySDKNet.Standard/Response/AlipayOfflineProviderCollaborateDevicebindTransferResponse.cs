using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindTransferResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateDevicebindTransferResponse : AopResponse
    {
        /// <summary>
        /// 如果换smid必须有
        /// </summary>
        [XmlElement("device_record_files")]
        public DeviceRecordInfo DeviceRecordFiles { get; set; }

        /// <summary>
        /// 需要换信息的SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备相关信息
        /// </summary>
        [XmlElement("ext_params")]
        public DeviceExtAttribute ExtParams { get; set; }

        /// <summary>
        /// 旧设备序列号，如果是换设备SN必有
        /// </summary>
        [XmlElement("old_device_sn")]
        public string OldDeviceSn { get; set; }
    }
}
