using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsFacedbDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsFacedbDeleteModel : AopObject
    {
        /// <summary>
        /// 人脸ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
