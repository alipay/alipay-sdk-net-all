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

        /// <summary>
        /// 商户标签，商户生成后的标签，可定位到此商户
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
