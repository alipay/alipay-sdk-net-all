using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsFacedbCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsFacedbCreateModel : AopObject
    {
        /// <summary>
        /// 人脸ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 人脸图片数据
        /// </summary>
        [XmlElement("face_image")]
        public string FaceImage { get; set; }

        /// <summary>
        /// floor_num（用户入住楼层），非必填，用于梯控场景，酒店用户入住后，刷脸乘电梯，仅拥有入住楼层按钮权限。
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
