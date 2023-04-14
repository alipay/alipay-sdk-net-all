using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FailFaceUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FailFaceUserInfo : AopObject
    {
        /// <summary>
        /// 错误码。
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 当前失败用户是否可以重试。{true：可重试，false：不可重试}
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 服务商内部用户唯一id。
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
