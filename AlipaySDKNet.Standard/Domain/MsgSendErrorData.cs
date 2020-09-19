using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgSendErrorData Data Structure.
    /// </summary>
    [Serializable]
    public class MsgSendErrorData : AopObject
    {
        /// <summary>
        /// 错误吗
        /// </summary>
        [XmlElement("error_code")]
        public long ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 登录id
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }
    }
}
