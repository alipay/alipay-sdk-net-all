using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NOrderTagBindResp Data Structure.
    /// </summary>
    [Serializable]
    public class NOrderTagBindResp : AopObject
    {
        /// <summary>
        /// 服务商调用接口绑定点位和物料关系时的现场作业图片
        /// </summary>
        [XmlArray("bind_pic")]
        [XmlArrayItem("string")]
        public List<string> BindPic { get; set; }

        /// <summary>
        /// 需要绑定点位的碰一下链接
        /// </summary>
        [XmlArray("nfc_url")]
        [XmlArrayItem("string")]
        public List<string> NfcUrl { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 作业人员姓名
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 作业人员手机号
        /// </summary>
        [XmlElement("operator_phone")]
        public string OperatorPhone { get; set; }

        /// <summary>
        /// 碰一下跳转链接，用于绑定链接，需与coil_no一一对应
        /// </summary>
        [XmlArray("route_url")]
        [XmlArrayItem("string")]
        public List<string> RouteUrl { get; set; }
    }
}
