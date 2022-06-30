using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsHotelroomModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsHotelroomModifyModel : AopObject
    {
        /// <summary>
        /// 涂鸦生成传入的人脸ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 解除绑定的关系的设备列表
        /// </summary>
        [XmlArray("source_sn_list")]
        [XmlArrayItem("string")]
        public List<string> SourceSnList { get; set; }

        /// <summary>
        /// 需要绑定的设备sn列表
        /// </summary>
        [XmlArray("target_sn_list")]
        [XmlArrayItem("string")]
        public List<string> TargetSnList { get; set; }
    }
}
