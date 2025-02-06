using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateDevicebindTransferModel : AopObject
    {
        /// <summary>
        /// 如果换smid必须要传，smid和之前的smid必须是同一个支付宝账户下
        /// </summary>
        [XmlArray("device_record_files")]
        [XmlArrayItem("device_record_info")]
        public List<DeviceRecordInfo> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 发起操作的设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 如果需要改动其中的内容，则需要传，不改动的话，继承之前sn的信息
        /// </summary>
        [XmlElement("ext_params")]
        public DeviceExtAttribute ExtParams { get; set; }

        /// <summary>
        /// 需要被替换的设备，如果是换SN必须传
        /// </summary>
        [XmlElement("old_device_sn")]
        public string OldDeviceSn { get; set; }
    }
}
