using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemInfo : AopObject
    {
        /// <summary>
        /// 小程序商品-支付宝内部商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品可用类型
        /// </summary>
        [XmlElement("item_use_type")]
        public string ItemUseType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
