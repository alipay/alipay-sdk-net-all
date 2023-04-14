using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogApiQrdetectIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogApiQrdetectIdentifyModel : AopObject
    {
        /// <summary>
        /// 待检测的图片url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
