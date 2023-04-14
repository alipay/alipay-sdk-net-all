using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogApiQrdetectIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogApiQrdetectIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 是否有二维码
        /// </summary>
        [XmlElement("has_qr")]
        public bool HasQr { get; set; }

        /// <summary>
        /// 二维码内容识别
        /// </summary>
        [XmlArray("list_url")]
        [XmlArrayItem("string")]
        public List<string> ListUrl { get; set; }
    }
}
