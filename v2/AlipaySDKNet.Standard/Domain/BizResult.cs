using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizResult Data Structure.
    /// </summary>
    [Serializable]
    public class BizResult : AopObject
    {
        /// <summary>
        /// 编码后的真实业务信息
        /// </summary>
        [XmlElement("encoded_result_obj")]
        public string EncodedResultObj { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息，面向开发人员
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 中文错误信息，面向客户
        /// </summary>
        [XmlElement("error_view_msg")]
        public string ErrorViewMsg { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 业务成功失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
