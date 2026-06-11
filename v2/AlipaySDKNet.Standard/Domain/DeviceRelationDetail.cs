using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceRelationDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceRelationDetail : AopObject
    {
        /// <summary>
        /// 设备SN号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备关联的服务商pid
        /// </summary>
        [XmlElement("related_pid")]
        public string RelatedPid { get; set; }

        /// <summary>
        /// 设备供应商id,用于区分设备类型
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 设备TagSN编号
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }
    }
}
