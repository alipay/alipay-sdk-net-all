using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcOrderLineResult Data Structure.
    /// </summary>
    [Serializable]
    public class MpcOrderLineResult : AopObject
    {
        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 子订单id
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }

        /// <summary>
        /// 子订单状态
        /// </summary>
        [XmlElement("order_line_status")]
        public string OrderLineStatus { get; set; }

        /// <summary>
        /// 子订单应付金额(单位：分)
        /// </summary>
        [XmlElement("pay_fee")]
        public long PayFee { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [XmlElement("product_pic")]
        public string ProductPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_title")]
        public string ProductTitle { get; set; }

        /// <summary>
        /// SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_title")]
        public string SkuTitle { get; set; }
    }
}
