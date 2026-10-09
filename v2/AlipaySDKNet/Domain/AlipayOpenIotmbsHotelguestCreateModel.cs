using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsHotelguestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsHotelguestCreateModel : AopObject
    {
        /// <summary>
        /// face_id+用于酒店关联用户和房间等信息
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// floor_num+人脸入住的楼层
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

        /// <summary>
        /// project_id，项目唯一id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// sn，关联的房间的sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
