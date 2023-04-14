using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpeechRecordReportFailDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SpeechRecordReportFailDetail : AopObject
    {
        /// <summary>
        /// 校验错误编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 校验失败详情
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 服务商保证每条播报记录唯一，方便排查对数
        /// </summary>
        [XmlElement("speech_id")]
        public string SpeechId { get; set; }
    }
}
