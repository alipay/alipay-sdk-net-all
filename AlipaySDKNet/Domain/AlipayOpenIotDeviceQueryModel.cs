using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotDeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotDeviceQueryModel : AopObject
    {
        /// <summary>
        /// 设备ID：biztid
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选项[SN,ID] SN-使用supplier_id、device_sn联合作为设备唯一识别标识 ID-使用biztid作为设备唯一识别标识
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 设备序列号：SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 设备供应商ID：supplierId
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 查询类型[MERCHANT,SHOP]，MERCHANT-设备商户绑定关系
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
