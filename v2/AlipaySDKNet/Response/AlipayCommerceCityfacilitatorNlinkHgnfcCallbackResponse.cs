using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNlinkHgnfcCallbackResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorNlinkHgnfcCallbackResponse : AopResponse
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否可以重试
        /// </summary>
        [XmlElement("can_retry")]
        public bool CanRetry { get; set; }

        /// <summary>
        /// 耗时单位毫秒
        /// </summary>
        [XmlElement("cost_time")]
        public long CostTime { get; set; }

        /// <summary>
        /// 返回业务数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 设备端请求标识
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("ret_message")]
        public string RetMessage { get; set; }

        /// <summary>
        /// 业务服务标识
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 子结果码
        /// </summary>
        [XmlElement("sub_ret_code")]
        public string SubRetCode { get; set; }

        /// <summary>
        /// 子结果信息
        /// </summary>
        [XmlElement("sub_ret_message")]
        public string SubRetMessage { get; set; }

        /// <summary>
        /// 查询服务端日志使用
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }
    }
}
