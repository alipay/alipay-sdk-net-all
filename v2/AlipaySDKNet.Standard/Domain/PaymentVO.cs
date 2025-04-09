using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVO Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVO : AopObject
    {
        /// <summary>
        /// 订单优惠总金额
        /// </summary>
        [XmlElement("amount_discount")]
        public string AmountDiscount { get; set; }

        /// <summary>
        /// 商品总金额
        /// </summary>
        [XmlElement("amount_item")]
        public string AmountItem { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("amount_original")]
        public string AmountOriginal { get; set; }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        [XmlElement("amount_user")]
        public string AmountUser { get; set; }

        /// <summary>
        /// 配送优惠金额
        /// </summary>
        [XmlElement("delivery_discount_fee")]
        public string DeliveryDiscountFee { get; set; }

        /// <summary>
        /// 配送服务费，当前订单产生时该门店的配送费，配送服务费=基础配送费+特殊时段加价费用+距离加价费用-配送优惠金额，单位：元，保留2位小数
        /// </summary>
        [XmlElement("delivery_fee")]
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 基础配送费，单位：元，保留2位小数
        /// </summary>
        [XmlElement("delivery_price")]
        public string DeliveryPrice { get; set; }

        /// <summary>
        /// 距离加价费用，单位：元，保留2位小数
        /// </summary>
        [XmlElement("distance_markup_price")]
        public string DistanceMarkupPrice { get; set; }

        /// <summary>
        /// 商家应收款
        /// </summary>
        [XmlElement("merchant_receive")]
        public string MerchantReceive { get; set; }

        /// <summary>
        /// 医保支付金额
        /// </summary>
        [XmlElement("mi_amount")]
        public string MiAmount { get; set; }

        /// <summary>
        /// 打包费总金额，单位：元，保留2位小数
        /// </summary>
        [XmlElement("packing_fee")]
        public string PackingFee { get; set; }

        /// <summary>
        /// 购药saas平台支付单号，对应医保对账单中的平台订单号
        /// </summary>
        [XmlElement("pay_num")]
        public string PayNum { get; set; }

        /// <summary>
        /// 特殊时段加价费用，单位：元，保留2位小数
        /// </summary>
        [XmlElement("time_markup_price")]
        public string TimeMarkupPrice { get; set; }

        /// <summary>
        /// 此字段对应B站对账单中的商家订单号
        /// </summary>
        [XmlElement("yk_pay_no")]
        public string YkPayNo { get; set; }
    }
}
