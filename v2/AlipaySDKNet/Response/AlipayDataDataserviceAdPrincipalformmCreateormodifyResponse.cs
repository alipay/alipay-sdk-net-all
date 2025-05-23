using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalformmCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalformmCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 灯火商家信息唯一键id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }
    }
}
