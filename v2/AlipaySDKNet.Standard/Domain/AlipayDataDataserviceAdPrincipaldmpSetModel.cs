using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPrincipaldmpSetModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商户人群id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 人群状态： ENABLE:开启 DISABLE:关闭
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
