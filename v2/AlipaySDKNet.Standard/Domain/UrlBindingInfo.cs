using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UrlBindingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UrlBindingInfo : AopObject
    {
        /// <summary>
        /// 是否已申请线圈
        /// </summary>
        [XmlElement("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// 线圈URL
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
