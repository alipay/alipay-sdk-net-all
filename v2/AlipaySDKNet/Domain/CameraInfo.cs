using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CameraInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CameraInfo : AopObject
    {
        /// <summary>
        /// 验证码,用于兜底
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 摄像头ID, 同一个门店下id唯一
        /// </summary>
        [XmlElement("camera_id")]
        public string CameraId { get; set; }

        /// <summary>
        /// 完整的rtsp信息
        /// </summary>
        [XmlElement("rtsp")]
        public string Rtsp { get; set; }

        /// <summary>
        /// 萤石
        /// </summary>
        [XmlElement("vendor")]
        public string Vendor { get; set; }
    }
}
