using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpFinRiskIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpFinRiskIdentifyModel : AopObject
    {
        /// <summary>
        /// 标识所属的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 风控咨询的业务入参，需要JSON序列化后传入
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 请求id，用于链路追踪，方便双方排查
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 标识所属的风控场景或环节
        /// </summary>
        [XmlElement("risk_scene")]
        public string RiskScene { get; set; }
    }
}
