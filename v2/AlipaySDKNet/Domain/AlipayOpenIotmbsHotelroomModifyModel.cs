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
        /// floor_num（用户入住楼层），非必填，用于梯控场景，酒店用户入住后，刷脸乘电梯，仅拥有入住楼层按钮权限。
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

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
