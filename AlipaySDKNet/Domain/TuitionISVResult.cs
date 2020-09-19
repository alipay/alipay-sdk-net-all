using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVResult Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVResult : AopObject
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
