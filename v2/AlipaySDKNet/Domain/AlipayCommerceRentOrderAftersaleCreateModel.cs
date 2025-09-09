using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderAftersaleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderAftersaleCreateModel : AopObject
    {
        /// <summary>
        /// 补充描述
        /// </summary>
        [XmlElement("additional_description")]
        public string AdditionalDescription { get; set; }

        /// <summary>
        /// 申请售后的补充凭证，类型包括图片、视频等
        /// </summary>
        [XmlArray("additional_media_list")]
        [XmlArrayItem("aftersale_media_info_v_o")]
        public List<AftersaleMediaInfoVO> AdditionalMediaList { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("aftersale_type")]
        public string AftersaleType { get; set; }

        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 商家小程序对应的售后详情页路径地址，仅需传入小程序页面路径即可，且需是小程序内部页面路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 订单费用项明细列表
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("aftersale_pay_item_v_o")]
        public List<AftersalePayItemVO> PayItems { get; set; }

        /// <summary>
        /// 用户发起售后原因，具体传入规则如下： 1. 取消订单售后场景下，根据当前订单状态是「待发货」和「已发货」，可传入的原因类型不同： 1.1. 已发货：可传入TIMEOUT_FOR_CONFIRM、LOGISTICS_ILLEGAL、REJECT_TO_CONFIRM、NO_NEED、BUYER_AGREED、OTHER； 1.2. 待发货：可传入OTHER_CHANNEL_CHEAP、CHEAPER_ITEM、RENT_AMOUNT_OVER_PLAN、NO_NEED、NO_GOODS_OR_REJECT、NEED_TO_CHANGE_CHANNEL、NEED_TO_PAY_MANY_PERIOD_AMOUNT、CANNOT_CAONTACT_WITH_MERCHANT、OTHER。 2. 赔付售后场景下，如果pay_items中金额类型为INDEMNITY，则可以传入ITEM_DAMAGED、ITEM_REPAIR、ITEM_LOST和ITEM_DEPRECIATION；如果金额类型为LATE_FEE，则可以传入RETURN_EARLY和RETURN_OVERDUE。
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }
    }
}
