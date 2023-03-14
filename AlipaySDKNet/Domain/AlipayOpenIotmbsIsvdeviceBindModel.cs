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
        /// device_category+传入绑定设备的类型
        /// </summary>
        [XmlElement("device_category")]
        public string DeviceCategory { get; set; }

        /// <summary>
        /// floor_num+用户入住的楼层
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

        /// <summary>
        /// project_id+传入设备要绑定的项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// room_num+用户入住房间的房间号
        /// </summary>
        [XmlElement("room_num")]
        public string RoomNum { get; set; }

        /// <summary>
        /// scene_type+绑定设备使用的场景
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// sn+要进行绑定操作的设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
