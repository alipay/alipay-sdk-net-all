using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsDetail : AopObject
    {
        /// <summary>
        /// 支付宝定义的统一商品编号
        /// </summary>
        [XmlElement("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目树，从商品类目根节点到叶子节点的类目id组成，类目id值使用|分割
        /// </summary>
        [XmlElement("categories_tree")]
        public string CategoriesTree { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品的编号，该参数传入支付券上绑定商品goods_id, 倘若无支付券需要消费，该字段传入商品最小粒度的商品ID（如：若商品有sku粒度，则传商户sku粒度的ID）
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：<a href="https://opendocs.alipay.com/mini/06uila?pathHash=63b6fba7">https://opendocs.alipay.com/mini/06uila?pathHash=63b6fba7</a>
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：<a target="_blank" href="https://opendocs.alipay.com/mini/06uila?pathHash=63b6fba7" >https://opendocs.alipay.com/mini/06uila?pathHash=63b6fba7</a>
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品单价，单位为元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [XmlElement("show_url")]
        public string ShowUrl { get; set; }
    }
}
