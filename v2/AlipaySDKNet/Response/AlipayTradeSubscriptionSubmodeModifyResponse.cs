using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionSubmodeModifyResponse.
    /// </summary>
    public class AlipayTradeSubscriptionSubmodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 长链，适用于跳转拉起支付宝端，升级/降级/取消后撤销场景会返回 升级：alipays://platformapi/startApp?appId=60000157&orderStr=XXXXXXXXXX；降级/取消后撤销：https://render.alipay.com/XXXXXXXXXX
        /// </summary>
        [XmlElement("alipay_jump_schema")]
        public string AlipayJumpSchema { get; set; }

        /// <summary>
        /// 短链，适用于生成二维码；升级/降级/取消后撤销场景会返回
        /// </summary>
        [XmlElement("alipay_schema")]
        public string AlipaySchema { get; set; }

        /// <summary>
        /// 升级订阅时生成的支付请求单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 订阅修改时若传入优惠，生成的优惠信息
        /// </summary>
        [XmlElement("promotion_info")]
        public string PromotionInfo { get; set; }

        /// <summary>
        /// 退款金额，单位分，取消并退款场景下生成
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款业务单号，取消并退款场景下生成
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 订阅ID，订阅唯一标识
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
