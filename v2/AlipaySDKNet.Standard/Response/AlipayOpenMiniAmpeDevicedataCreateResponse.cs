using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicedataCreateResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicedataCreateResponse : AopResponse
    {
        /// <summary>
        /// 2000为失败，与ampe保持一致，在success为false时生效
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 上报失败原因
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 是否上报成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
