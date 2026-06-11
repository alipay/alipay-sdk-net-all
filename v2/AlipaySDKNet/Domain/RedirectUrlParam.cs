using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RedirectUrlParam Data Structure.
    /// </summary>
    [Serializable]
    public class RedirectUrlParam : AopObject
    {
        /// <summary>
        /// 端
        /// </summary>
        [XmlElement("client")]
        public string Client { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
