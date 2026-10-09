using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TouchUvInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TouchUvInfo : AopObject
    {
        /// <summary>
        /// 二维码链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 唤端UV
        /// </summary>
        [XmlElement("touch_uv")]
        public long TouchUv { get; set; }
    }
}
