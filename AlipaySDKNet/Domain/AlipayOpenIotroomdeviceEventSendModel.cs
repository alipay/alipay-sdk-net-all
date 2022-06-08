using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotroomdeviceEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotroomdeviceEventSendModel : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 是否操作开门，true：操作开门，false：不开门
        /// </summary>
        [XmlElement("door_state")]
        public bool DoorState { get; set; }

        /// <summary>
        /// 人脸ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 开门失败原因描述
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
