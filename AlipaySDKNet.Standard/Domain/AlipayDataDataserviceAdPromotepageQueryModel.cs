using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPromotepageQueryModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 灯火商家ID
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 推广页类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
