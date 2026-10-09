using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableOutItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableOutItemInfo : AopObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("item_app_id")]
        public string ItemAppId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
