using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMallOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportMallOrderCreateModel : AopObject
    {
        /// <summary>
        /// 车辆品牌Id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 车辆品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 车系ID
        /// </summary>
        [XmlElement("car_series")]
        public string CarSeries { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("car_series_name")]
        public string CarSeriesName { get; set; }

        /// <summary>
        /// 操作审计人
        /// </summary>
        [XmlElement("create_by")]
        public string CreateBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商品价格 单位：元{"fieldDesc":"元"}
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 充值状态 2, "开通成功"
        /// </summary>
        [XmlElement("ecology_status")]
        public long EcologyStatus { get; set; }

        /// <summary>
        /// 第一支付类型
        /// </summary>
        [XmlElement("first_pay_type")]
        public string FirstPayType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品价格 单位：元{"fieldDesc":"元"}
        /// </summary>
        [XmlElement("goods_price")]
        public string GoodsPrice { get; set; }

        /// <summary>
        /// 商品标识
        /// </summary>
        [XmlElement("goods_supplier")]
        public long GoodsSupplier { get; set; }

        /// <summary>
        /// 商品类型ID
        /// </summary>
        [XmlElement("goods_type_id")]
        public string GoodsTypeId { get; set; }

        /// <summary>
        /// 商品类型名称
        /// </summary>
        [XmlElement("goods_type_name")]
        public string GoodsTypeName { get; set; }

        /// <summary>
        /// SIM卡标识
        /// </summary>
        [XmlElement("iccid")]
        public string Iccid { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_biz_type")]
        public string OrderBizType { get; set; }

        /// <summary>
        /// 订单来源渠道
        /// </summary>
        [XmlElement("order_channel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// 订单xx原因
        /// </summary>
        [XmlElement("order_invalid_reason")]
        public string OrderInvalidReason { get; set; }

        /// <summary>
        /// 订单状态 "0", "已提交未支付 "1", "已提交已支付" "2", "已支付未发货" "3", "已支付已发货" "4", "已失效"
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 父订单编号
        /// </summary>
        [XmlElement("parent_order_no")]
        public string ParentOrderNo { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 充值手机号
        /// </summary>
        [XmlElement("recharge_phone")]
        public string RechargePhone { get; set; }

        /// <summary>
        /// 幂等ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 第二支付类型
        /// </summary>
        [XmlElement("second_pay_type")]
        public string SecondPayType { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }

        /// <summary>
        /// 系统标识
        /// </summary>
        [XmlElement("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 第三方创建时间
        /// </summary>
        [XmlElement("third_create_time")]
        public string ThirdCreateTime { get; set; }

        /// <summary>
        /// 第三方的用户ID
        /// </summary>
        [XmlElement("third_id")]
        public string ThirdId { get; set; }

        /// <summary>
        /// 第三方订单状态 "0", "未支付" "1", "支付成功" "2", "支付失败"
        /// </summary>
        [XmlElement("third_order_status")]
        public string ThirdOrderStatus { get; set; }

        /// <summary>
        /// 第三方支付时间
        /// </summary>
        [XmlElement("third_payment_time")]
        public string ThirdPaymentTime { get; set; }

        /// <summary>
        /// 总价 单位：元{"fieldDesc":"元"}
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 商品价格 单位：元{"fieldDesc":"元"}
        /// </summary>
        [XmlElement("trade_price")]
        public string TradePrice { get; set; }

        /// <summary>
        /// 更新操作审计人
        /// </summary>
        [XmlElement("update_by")]
        public string UpdateBy { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 车辆识别码
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
