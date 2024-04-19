using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotDeviceUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotDeviceUnbindModel : AopObject
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
        /// 商户编号，由ISV定义，需要保证在ISV下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商户角色id。对于直连开店场景，填写商户pid；对于间连开店场景，填写商户smid。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 区分商户ID类型，直连商户填写direct，间连商户填写indirect
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 受理商户的ISV在支付宝的pid
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 设备供应商ID：supplierId
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
