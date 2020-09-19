using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Result Data Structure.
    /// </summary>
    [Serializable]
    public class Result : AopObject
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果详细信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 结果状态，包含： S 成功 F 失败 U 未知异常
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
