using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceEcoBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceEcoBindModel : AopObject
    {
        /// <summary>
        /// 绑定类型，可选项[SUB_MERCHANT,DIRECT_MERCHANT]
        /// </summary>
        [XmlElement("bind_type")]
        public string BindType { get; set; }

        /// <summary>
        /// 绑定用户id
        /// </summary>
        [XmlElement("bind_user_id")]
        public string BindUserId { get; set; }

        /// <summary>
        /// 设备唯一标识，设备id;identity_type='ID'时必填
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选项[SN,ID] SN-使用device_sn、supplier_id联合作为设备唯一识别标识 ID-使用biz_tid作为设备唯一识别标识
        /// </summary>
        [XmlElement("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 收钱码SN，按需写入
        /// </summary>
        [XmlElement("paycode_sn")]
        public string PaycodeSn { get; set; }

        /// <summary>
        /// 设备sn，与supplier_id配合作为设备识别的唯一标识;identity_type='SN'时必填
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商id，与sn配合作为设备识别唯一标识;identity_type='SN'时必填
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
