using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubsidySimpleResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SubsidySimpleResponse : AopObject
    {
        /// <summary>
        /// 商家自设/大运河等传参类权益详细信息（期数粒度）
        /// </summary>
        [XmlArray("activity_subsidy_list")]
        [XmlArrayItem("activity_subsidy_model")]
        public List<ActivitySubsidyModel> ActivitySubsidyList { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("good_item_id")]
        public string GoodItemId { get; set; }

        /// <summary>
        /// 1、贴息支付核销时所需的字段，依赖收银、收单无脑透传 期数粒度贴息支付所需的信息返回淘宝，在用户选择资产+期数都进行匹配 -> 确认交易时透传给主站收单 2、商品信息
        /// </summary>
        [XmlElement("installment_biz_info")]
        public string InstallmentBizInfo { get; set; }

        /// <summary>
        /// 期数粒度、免息/折扣/商家贴息信息
        /// </summary>
        [XmlArray("installment_int_discount_info")]
        [XmlArrayItem("installment_int_discount_model")]
        public List<InstallmentIntDiscountModel> InstallmentIntDiscountInfo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 调用结果：resultFlag 错误码：errorCode 错误信息描述：errorMessage
        /// </summary>
        [XmlElement("result_message")]
        public ResultMessage ResultMessage { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 分期卡券/活动权益相关信息详情（期数粒度）
        /// </summary>
        [XmlArray("voucher_subsidy_list")]
        [XmlArrayItem("voucher_subsidy_model")]
        public List<VoucherSubsidyModel> VoucherSubsidyList { get; set; }
    }
}
