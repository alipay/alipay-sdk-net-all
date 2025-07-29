using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderInfoVO : AopObject
    {
        /// <summary>
        /// 订单取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 商家接单时间
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单发货时间
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 配送方式
        /// </summary>
        [XmlElement("delivery_type")]
        public long DeliveryType { get; set; }

        /// <summary>
        /// 订单完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 1是自费订单，2是医保订单
        /// </summary>
        [XmlElement("mi_type")]
        public long MiType { get; set; }

        /// <summary>
        /// 下单备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单的场景值   1:O2O订单，2:B2C订单
        /// </summary>
        [XmlElement("order_scene")]
        public long OrderScene { get; set; }

        /// <summary>
        /// 当日订单顺序号
        /// </summary>
        [XmlElement("order_seq")]
        public string OrderSeq { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 取货类型
        /// </summary>
        [XmlElement("pick_type")]
        public long PickType { get; set; }

        /// <summary>
        /// 送达时间类型
        /// </summary>
        [XmlElement("pre_order_type")]
        public long PreOrderType { get; set; }

        /// <summary>
        /// 预计最晚送达时间
        /// </summary>
        [XmlElement("predict_delivery_end_time")]
        public string PredictDeliveryEndTime { get; set; }

        /// <summary>
        /// 预计最早送达时间
        /// </summary>
        [XmlElement("predict_delivery_start_time")]
        public string PredictDeliveryStartTime { get; set; }

        /// <summary>
        /// 商品总数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 1-处方订单，2-非处方订单
        /// </summary>
        [XmlElement("rx_type")]
        public long RxType { get; set; }

        /// <summary>
        /// 订单更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 用户期望最晚送达时间 当前字段已废弃(该字段和预计最晚送达时间重复，后续取预计最晚送达时间即可)
        /// </summary>
        [XmlElement("user_expect_end_time")]
        public string UserExpectEndTime { get; set; }

        /// <summary>
        /// 用户期望最早送达时间 当前字段已废弃(该字段和预计最早送达时间重复，后续取预计最早送达时间即可)
        /// </summary>
        [XmlElement("user_expect_start_time")]
        public string UserExpectStartTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 商品总重量，保留小数点后3位 + 单位， 单位固定两种（g和ml） 当前字段已废弃(商品总重量由items-weight_item汇总计算即可)
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }
    }
}
