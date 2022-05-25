using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeCardItemExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeCardItemExtendInfo : AopObject
    {
        /// <summary>
        /// 小程序跳转链接
        /// </summary>
        [XmlElement("action_link")]
        public string ActionLink { get; set; }

        /// <summary>
        /// 扩展描述
        /// </summary>
        [XmlElement("ext_desc")]
        public string ExtDesc { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
