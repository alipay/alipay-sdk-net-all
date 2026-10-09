using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsFacecheckSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsFacecheckSendModel : AopObject
    {
        /// <summary>
        /// 设备激活序号
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 人脸ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// floor_num（用户入住楼层），非必填，用于梯控场景，酒店用户入住后，刷脸乘电梯，仅拥有入住楼层按钮权限。
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

        /// <summary>
        /// 外部传入的请求序号
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

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
        /// 刷脸开门设备，sn列表
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }
    }
}
