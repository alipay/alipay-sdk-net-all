using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SCardQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class SCardQueryVO : AopObject
    {
        /// <summary>
        /// 背景图
        /// </summary>
        [XmlElement("back_img")]
        public string BackImg { get; set; }

        /// <summary>
        /// 权益价值-单位分
        /// </summary>
        [XmlElement("item_amount")]
        public long ItemAmount { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 优惠信息名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 售卖价格-单位分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
