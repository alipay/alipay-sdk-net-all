using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchSubservicekeywordDeleteModel : AopObject
    {
        /// <summary>
        /// 关键词配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
