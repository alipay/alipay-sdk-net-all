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
        /// true: 绑定，false：解绑
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
        /// 商家用户ID
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
