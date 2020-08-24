using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IntentQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IntentQueryResponse : AopObject
    {
        /// <summary>
        /// 对应用户的queryId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 结果编码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果json
        /// </summary>
        [XmlElement("result_json")]
        public string ResultJson { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
