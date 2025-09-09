using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpFinRiskIdentifyResponse.
    /// </summary>
    public class ZhimaCreditEpFinRiskIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 与入参中的request_id保持一致，标识某一次请求的返回结果
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 风控决策结果，由JSON序列化得到，需要反序列化后使用
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
