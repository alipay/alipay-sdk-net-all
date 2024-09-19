using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundOrderDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class RefundOrderDetailVO : AopObject
    {
        /// <summary>
        /// 退款总金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品退款金额，单位：元
        /// </summary>
        [XmlElement("amount_item")]
        public string AmountItem { get; set; }

        /// <summary>
        /// 个人自付退款金额，单位：元
        /// </summary>
        [XmlElement("amount_user")]
        public string AmountUser { get; set; }

        /// <summary>
        /// 退款申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 退款确认时间
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 配送优惠金额，单位：元
        /// </summary>
        [XmlElement("delivery_discount_fee")]
        public string DeliveryDiscountFee { get; set; }

        /// <summary>
        /// 配送费退款金额，单位：元
        /// </summary>
        [XmlElement("delivery_fee")]
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 基础配送费，单位：元
        /// </summary>
        [XmlElement("delivery_price")]
        public string DeliveryPrice { get; set; }

        /// <summary>
        /// 距离加价费用，单位：元
        /// </summary>
        [XmlElement("distance_markup_price")]
        public string DistanceMarkupPrice { get; set; }

        /// <summary>
        /// 退款图片url，用户在申请退款时上传的退款图片，上限为6张。
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 退款商品集合
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("refund_item_v_o")]
        public List<RefundItemVO> Items { get; set; }

        /// <summary>
        /// 医保信息
        /// </summary>
        [XmlElement("medicare")]
        public MedicareVO Medicare { get; set; }

        /// <summary>
        /// 医保退款金额，单位：元
        /// </summary>
        [XmlElement("mi_amount")]
        public string MiAmount { get; set; }

        /// <summary>
        /// 退款发起角色:1 用户,2 商户
        /// </summary>
        [XmlElement("operator_role")]
        public string OperatorRole { get; set; }

        /// <summary>
        /// 打包费退款金额，单位：元
        /// </summary>
        [XmlElement("packing_fee")]
        public string PackingFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退款原因code
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 退款状态描述
        /// </summary>
        [XmlElement("refund_msg")]
        public string RefundMsg { get; set; }

        /// <summary>
        /// 退款订单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款类型：1-全额退款；2-部分退款；3-退差价
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 退款拒绝原因描述
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 退款拒绝原因
        /// </summary>
        [XmlElement("refuse_reason_code")]
        public string RefuseReasonCode { get; set; }

        /// <summary>
        /// 退款到账时间
        /// </summary>
        [XmlElement("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 特殊时段加价费用，单位：元
        /// </summary>
        [XmlElement("time_markup_price")]
        public string TimeMarkupPrice { get; set; }
    }
}
