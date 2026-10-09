using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPrivatebindSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPrivatebindSyncModel : AopObject
    {
        /// <summary>
        /// true: 绑定，false：解绑；支持user_id和phone_num绑定，支持user_id解绑
        /// </summary>
        [XmlElement("bind_status")]
        public bool BindStatus { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlElement("equipment_info")]
        public PrivateChargingEquipment EquipmentInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 商家侧的用户ID
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 用户的支付宝登陆手机号。通过手机号绑定，仅针对部分场景，需联系业务或技术支持配置开放。
        /// </summary>
        [XmlElement("phone_num")]
        public string PhoneNum { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
