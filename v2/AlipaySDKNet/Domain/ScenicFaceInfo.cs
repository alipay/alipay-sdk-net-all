using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicFaceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicFaceInfo : AopObject
    {
        /// <summary>
        /// 用户场景下唯一标示码。（注：请确保传入face_id的自然人维度全局唯一）
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 人脸系统唯一身份标识
        /// </summary>
        [XmlElement("zid")]
        public string Zid { get; set; }
    }
}
