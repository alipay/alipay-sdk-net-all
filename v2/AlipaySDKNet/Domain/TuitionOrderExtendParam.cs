using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionOrderExtendParam Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionOrderExtendParam : AopObject
    {
        /// <summary>
        /// 支付后回跳地址
        /// </summary>
        [XmlElement("returnback_url")]
        public string ReturnbackUrl { get; set; }
    }
}
