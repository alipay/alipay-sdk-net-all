using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolServiceorderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolServiceorderModifyModel : AopObject
    {
        /// <summary>
        /// 阿里云呼入任务更新模型
        /// </summary>
        [XmlElement("csi_payload")]
        public CustomeServiceInboundUpdateDTO CsiPayload { get; set; }

        /// <summary>
        /// 是否调度模式
        /// </summary>
        [XmlElement("dispatch_mode")]
        public bool DispatchMode { get; set; }

        /// <summary>
        /// 收单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 上一次服务唯一码
        /// </summary>
        [XmlElement("origin_service_uniq_code")]
        public string OriginServiceUniqCode { get; set; }

        /// <summary>
        /// 服务唯一码
        /// </summary>
        [XmlElement("service_uniq_code")]
        public string ServiceUniqCode { get; set; }

        /// <summary>
        /// 源头id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 来源系统名称
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 服务工单任务更新模型
        /// </summary>
        [XmlElement("st_payload")]
        public ServiceTicketUpdateDTO StPayload { get; set; }

        /// <summary>
        /// 请求来源的租户
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
