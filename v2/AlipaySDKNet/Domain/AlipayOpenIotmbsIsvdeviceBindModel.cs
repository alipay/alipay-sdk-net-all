using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvdeviceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvdeviceBindModel : AopObject
    {
        /// <summary>
        /// 设备蓝牙mac地址
        /// </summary>
        [XmlElement("bt_mac")]
        public string BtMac { get; set; }

        /// <summary>
        /// 传入绑定设备的类型。 枚举值： 1:蜻蜓前台设备 2:蜻蜓房门设备 3:蜻蜓公区设备 11:咖啡机 12:洗衣机 13:视觉货柜 14:送物机器人 15:客控音响 16:弹簧机 17:小型售货机 当前字段已废弃(此字段废弃，无需传值。)
        /// </summary>
        [XmlElement("device_category")]
        public string DeviceCategory { get; set; }

        /// <summary>
        /// 设备所属类型
        /// </summary>
        [XmlElement("device_category_code")]
        public string DeviceCategoryCode { get; set; }

        /// <summary>
        /// 设备所使用的解决方案
        /// </summary>
        [XmlElement("device_solution")]
        public string DeviceSolution { get; set; }

        /// <summary>
        /// 用户入住的楼层
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

        /// <summary>
        /// 传入设备要绑定的项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户入住房间的房间号
        /// </summary>
        [XmlElement("room_num")]
        public string RoomNum { get; set; }

        /// <summary>
        /// 设备所处场景类目
        /// </summary>
        [XmlElement("scene_category_code")]
        public string SceneCategoryCode { get; set; }

        /// <summary>
        /// 绑定设备使用的场景 枚举值： 1:酒店前台设备 2:刷脸开门设备 3:刷脸乘梯设备 4:刷脸门禁设备 5:刷脸闸机设备 6:刷脸就餐设备 7:公区共享设备 8:网吧前台设备 当前字段已废弃(此字段废弃，无需传值。)
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 要进行绑定操作的设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
