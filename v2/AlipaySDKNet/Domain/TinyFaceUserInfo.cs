using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TinyFaceUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TinyFaceUserInfo : AopObject
    {
        /// <summary>
        /// 人脸库扩展字段修改后的信息。(如果需要清空扩展字段，需使用空json——“{}”)
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 人脸id。
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 用户在服务商系统内的唯一id。
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
