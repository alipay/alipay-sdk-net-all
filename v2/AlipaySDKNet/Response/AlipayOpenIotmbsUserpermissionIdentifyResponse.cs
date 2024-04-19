using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsUserpermissionIdentifyResponse.
    /// </summary>
    public class AlipayOpenIotmbsUserpermissionIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 返回鉴权结果
        /// </summary>
        [XmlElement("permit")]
        public string Permit { get; set; }

        /// <summary>
        /// 核身平台提供的用户vid
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
