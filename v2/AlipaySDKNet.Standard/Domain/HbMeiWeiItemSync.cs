using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbMeiWeiItemSync Data Structure.
    /// </summary>
    [Serializable]
    public class HbMeiWeiItemSync : AopObject
    {
        /// <summary>
        /// 宝贝票面价值,单位为分
        /// </summary>
        [XmlElement("amount_rights")]
        public long AmountRights { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [XmlElement("biz_item_id")]
        public string BizItemId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 宝贝售价,单位为分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [XmlElement("sale_count")]
        public long SaleCount { get; set; }

        /// <summary>
        /// 宝贝状态，1:上架状态，0:下架状态，默认为0
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 访问量
        /// </summary>
        [XmlElement("uv_count")]
        public long UvCount { get; set; }
    }
}
