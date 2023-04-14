using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCreateExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCreateExtInfo : AopObject
    {
        /// <summary>
        /// 小程序跳转链接
        /// </summary>
        [XmlElement("action_link")]
        public string ActionLink { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("ext_desc")]
        public string ExtDesc { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
