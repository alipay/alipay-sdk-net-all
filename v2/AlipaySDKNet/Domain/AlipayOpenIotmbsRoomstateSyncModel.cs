using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsRoomstateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsRoomstateSyncModel : AopObject
    {
        /// <summary>
        /// 设备激活序号
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 房间开关的状态，1正常2勿扰3清扫4稍后
        /// </summary>
        [XmlElement("room_state")]
        public long RoomState { get; set; }
    }
}
