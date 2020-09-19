using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SchoolBatchQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class SchoolBatchQueryResult : AopObject
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
