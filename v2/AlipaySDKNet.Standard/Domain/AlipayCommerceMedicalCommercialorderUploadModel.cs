using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialorderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialorderUploadModel : AopObject
    {
        /// <summary>
        /// 支付金额，精确到小数点后2位，单位为元。 当订单状态为“已支付”、“使用中”、“已完成”、“已出报告”、“已退款”、“部分退款”时必填
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 支付宝收单系统生成的交易订单号。当订单状态为“已支付”、“使用中”、“已完成”、“已出报告”、“已退款”、“部分退款”时必填
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户open_id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("buyer_uid")]
        public string BuyerUid { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public MedicalCommercialOrderUploadExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 商品编码，商品入驻时可以获取，app_code于out_goods_id需要相匹配
        /// </summary>
        [XmlElement("goods_app_code")]
        public string GoodsAppCode { get; set; }

        /// <summary>
        /// 商户自定义的商品描述
        /// </summary>
        [XmlElement("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 商户自定义的商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商户侧的订单详情页链接
        /// </summary>
        [XmlElement("merchant_order_detail_url")]
        public string MerchantOrderDetailUrl { get; set; }

        /// <summary>
        /// 订单金额，精确到小数点后2位，单位为元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间，格式为"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间，订单信息变更时必须变化，保持最新，格式为"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单状态，和订单类型强相关，状态之间的跳转有限制。详见集成文档
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型，固定值COMMERCIAL_ORDER
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户自身订单号，需要保证同一商户pid下out_biz_no的唯一性，作为订单唯一标识。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 妇幼：OBSTETRICS_AND_PEDIATRICS 医美：MEDICAL_COSMETOLOGY 体检：MEDICAL_EXAMINATION 疫苗：VACCINE
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 商户自定义的外部商品id，与入驻光华的app_code匹配
        /// </summary>
        [XmlElement("out_goods_id")]
        public string OutGoodsId { get; set; }
    }
}
