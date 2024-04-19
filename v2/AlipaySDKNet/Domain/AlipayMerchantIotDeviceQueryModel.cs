using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIotDeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIotDeviceQueryModel : AopObject
    {
        /// <summary>
        /// 设备 ID ，device_id_type 为 ID 时填写。
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选方式 [ID,SN]。ID-使用biztid作为设备唯一识别标识；SN-使用supplier_id、device_sn联合作为设备唯一识别标识。由于不同机型的supplier_id不同，推荐使用 ID 。
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
