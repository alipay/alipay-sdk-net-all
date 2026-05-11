using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagUrlInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TagUrlInfo : AopObject
    {
        /// <summary>
        /// nfc链接
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }

        /// <summary>
        /// 用于跳转小程序
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }

        /// <summary>
        /// 线圈id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 线圈sn
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }
    }
}
