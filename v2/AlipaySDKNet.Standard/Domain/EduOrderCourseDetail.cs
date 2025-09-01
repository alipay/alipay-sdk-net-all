using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduOrderCourseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class EduOrderCourseDetail : AopObject
    {
        /// <summary>
        /// 上课结束日期
        /// </summary>
        [XmlElement("course_end_date")]
        public string CourseEndDate { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 上课起始日期
        /// </summary>
        [XmlElement("course_start_date")]
        public string CourseStartDate { get; set; }

        /// <summary>
        /// 直减金额/手续费/亏损费，度量单位人民币，单位：元。
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣除金额类型，请参考枚举
        /// </summary>
        [XmlElement("deduction_amount_type")]
        public string DeductionAmountType { get; set; }

        /// <summary>
        /// 订单明细ID
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 折扣（百分比，9折即存90，计算需转换）
        /// </summary>
        [XmlElement("discount")]
        public long Discount { get; set; }

        /// <summary>
        /// 赠送数量/转出赠送数量
        /// </summary>
        [XmlElement("gift_quantity")]
        public string GiftQuantity { get; set; }

        /// <summary>
        /// 赠送数量单位 CLASS_HOUR：课时 DAY：天 MONTH：月 PIECE：件 PACKET：笔 YUAN：元
        /// </summary>
        [XmlElement("gift_quantity_unit")]
        public string GiftQuantityUnit { get; set; }

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
        /// 关联原订单id（转课、退课、退物品、退费用）
        /// </summary>
        [XmlElement("ori_order_id")]
        public string OriOrderId { get; set; }

        /// <summary>
        /// 商品原金额/转出金额（含手续费）/转出金额（不含亏损费），单位：元。
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 优惠后金额/转出金额（不含手续费）/转出金额（含亏损费），单位：元。
        /// </summary>
        [XmlElement("original_price_after_discount")]
        public string OriginalPriceAfterDiscount { get; set; }

        /// <summary>
        /// INCOME-收入 EXPENSE-支出
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// COURSE：课程 ARTICLE：物品 FEE：费用 RECHARGE：充值
        /// </summary>
        [XmlElement("purchase_item_type")]
        public string PurchaseItemType { get; set; }

        /// <summary>
        /// 购买数量或转出购买数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 购买数量单位 CLASS_HOUR：课时 DAY：天 MONTH：月 PIECE：件 PACKET：笔
        /// </summary>
        [XmlElement("quantity_unit")]
        public string QuantityUnit { get; set; }

        /// <summary>
        /// 商品规格价格，单位：元。
        /// </summary>
        [XmlElement("spec_current_price")]
        public string SpecCurrentPrice { get; set; }

        /// <summary>
        /// 商品规格ID
        /// </summary>
        [XmlElement("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 所属套餐商品ID，若为-1，表示商品不在某个套餐中
        /// </summary>
        [XmlElement("suite_commodity_id")]
        public string SuiteCommodityId { get; set; }

        /// <summary>
        /// 所属套餐商品名称
        /// </summary>
        [XmlElement("suite_commodity_name")]
        public string SuiteCommodityName { get; set; }

        /// <summary>
        /// 欠费金额，单位：元。
        /// </summary>
        [XmlElement("unpaid_amount")]
        public string UnpaidAmount { get; set; }
    }
}
