using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNlinkHgnfcCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorNlinkHgnfcCallbackModel : AopObject
    {
        /// <summary>
        /// 业务服务标识对应的参数
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 设备端生成的碰请求标识
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 业务标识处理id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
