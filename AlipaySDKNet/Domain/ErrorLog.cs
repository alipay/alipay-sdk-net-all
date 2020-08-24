using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ErrorLog Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorLog : AopObject
    {
        /// <summary>
        /// 错误发生时间
        /// </summary>
        [XmlElement("datetime")]
        public string Datetime { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 支付宝登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 错误日志ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
