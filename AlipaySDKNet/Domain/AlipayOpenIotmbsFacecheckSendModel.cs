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
