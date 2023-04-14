using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityFaceOutEventApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityFaceOutEventApiResponse : AopObject
    {
        /// <summary>
        /// 错误的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 状态，1处理中2成功3失败
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }
    }
}
