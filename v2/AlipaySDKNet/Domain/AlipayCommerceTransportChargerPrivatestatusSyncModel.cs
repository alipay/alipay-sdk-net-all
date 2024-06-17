using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPrivatestatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPrivatestatusSyncModel : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("equip_id")]
        public string EquipId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家用户ID
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 同步时间戳
        /// </summary>
        [XmlElement("sync_timestamp")]
        public string SyncTimestamp { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
