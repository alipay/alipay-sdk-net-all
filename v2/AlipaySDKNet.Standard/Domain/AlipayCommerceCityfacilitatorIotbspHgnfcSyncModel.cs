using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspHgnfcSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotbspHgnfcSyncModel : AopObject
    {
        /// <summary>
        /// 行业openapi同步信息，具体为初始化信息、注册信息、设备信息等
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 0b446a3f17168015507584370e03f4
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 业务标识处理id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
