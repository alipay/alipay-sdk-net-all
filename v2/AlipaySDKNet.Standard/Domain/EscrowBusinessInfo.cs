using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EscrowBusinessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EscrowBusinessInfo : AopObject
    {
        /// <summary>
        /// 网站类型，取值：PC_WEB、MOBILE_WEB
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 图片ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("mrch_biz_address")]
        public string MrchBizAddress { get; set; }

        /// <summary>
        /// ONLINE_WEBAPP  在线web应用
        /// </summary>
        [XmlElement("place_type")]
        public string PlaceType { get; set; }

        /// <summary>
        /// 经营场所url
        /// </summary>
        [XmlElement("place_url")]
        public string PlaceUrl { get; set; }
    }
}
