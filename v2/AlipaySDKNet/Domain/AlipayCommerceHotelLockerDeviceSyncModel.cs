using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelLockerDeviceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelLockerDeviceSyncModel : AopObject
    {
        /// <summary>
        /// 所属支付宝侧机构ID
        /// </summary>
        [XmlElement("alipay_org_id")]
        public string AlipayOrgId { get; set; }

        /// <summary>
        /// 服务商内部楼宇ID
        /// </summary>
        [XmlElement("building_id")]
        public string BuildingId { get; set; }

        /// <summary>
        /// 楼宇名称
        /// </summary>
        [XmlElement("building_name")]
        public string BuildingName { get; set; }

        /// <summary>
        /// 楼宇编号
        /// </summary>
        [XmlElement("building_no")]
        public string BuildingNo { get; set; }

        /// <summary>
        /// 设备ID（系统内ID）
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备系统集成服务商
        /// </summary>
        [XmlElement("device_isv_code")]
        public string DeviceIsvCode { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 烧入设备中的厂商编码
        /// </summary>
        [XmlElement("device_p_code")]
        public string DevicePCode { get; set; }

        /// <summary>
        /// 设备编号（开锁设备中的唯一编号）
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// ROOM_LOCK-房间门锁 LIFT-梯控
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备当前是否有效，默认有效
        /// </summary>
        [XmlElement("effective")]
        public bool Effective { get; set; }

        /// <summary>
        /// 房间楼层
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 服务商侧机构ID
        /// </summary>
        [XmlElement("isv_org_id")]
        public string IsvOrgId { get; set; }

        /// <summary>
        /// 开锁主要方式 蓝牙-BLUETOOTH ，NFC-NFC ，远程网络-NETWORK， 广播-BROADCAST
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }

        /// <summary>
        /// 权限管理同步服务商code
        /// </summary>
        [XmlElement("operators_code")]
        public string OperatorsCode { get; set; }

        /// <summary>
        /// 所属集团code
        /// </summary>
        [XmlElement("org_group_code")]
        public string OrgGroupCode { get; set; }

        /// <summary>
        /// 关联房间名称
        /// </summary>
        [XmlElement("room_name")]
        public string RoomName { get; set; }

        /// <summary>
        /// 关联房间号
        /// </summary>
        [XmlElement("room_no")]
        public string RoomNo { get; set; }

        /// <summary>
        /// 梯控设备可以分组
        /// </summary>
        [XmlElement("team_name")]
        public string TeamName { get; set; }
    }
}
