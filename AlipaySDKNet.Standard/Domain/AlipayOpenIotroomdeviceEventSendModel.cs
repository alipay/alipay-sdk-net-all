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
        /// 人脸ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }
    }
}
