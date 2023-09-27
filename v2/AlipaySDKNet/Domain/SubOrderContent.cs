using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubOrderContent Data Structure.
    /// </summary>
    [Serializable]
    public class SubOrderContent : AopObject
    {
        /// <summary>
        /// 子订单优惠价格，单位：元
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 原始单价，单位：元。
        /// </summary>
        [XmlElement("origin_fee")]
        public string OriginFee { get; set; }

        /// <summary>
        /// 子订单实际支付价格，单位：元。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("pay_fee")]
        public string PayFee { get; set; }

        /// <summary>
        /// 子订单销售单价，单位：元。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 子订单对应的商品，购买的数量。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("sale_quantity")]
        public string SaleQuantity { get; set; }

        /// <summary>
        /// 子订单商品skuid（如果导入数据中，店铺下不存在对应id则当前商品为非有效商品，不会存储当前子订单，如果整张订单中都不存在有效商品，认为订单无效，整个订单都不存储）。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 子订单商品副标题，如颜色、型号。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 子订单商品标题。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 子订单商品图片地址，用于渲染。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlElement("title_img")]
        public string TitleImg { get; set; }
    }
}
