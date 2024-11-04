using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundScenepayOrderQueryResponse.
    /// </summary>
    public class AlipayFundScenepayOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易中包含的业务优惠金额 单位：元
        /// </summary>
        [XmlElement("biz_amount")]
        public string BizAmount { get; set; }

        /// <summary>
        /// 场景支付业务单号，由场景支付单创建接口获取
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("business_params")]
        public ScenePayBusinessParamDTO BusinessParams { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 交易付款时间 单位：年月日 时分秒
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 是否使用预期优惠 使用-true 未使用-false
        /// </summary>
        [XmlElement("is_use_expected_discount")]
        public string IsUseExpectedDiscount { get; set; }

        /// <summary>
        /// 场景支付业务单状态，可取值有： INIT：初始状态 PROCESSING：处理中 CLOSED：关单 SUCCESS：成功
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务号，请求唯一幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部商户单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 参与者信息
        /// </summary>
        [XmlElement("partner_info")]
        public ScenePayParticipantInfoDTO PartnerInfo { get; set; }

        /// <summary>
        /// 当交易发生退款时，该字段不为空，会把每次退款时的明细整合一起发送
        /// </summary>
        [XmlElement("refund_detail_list")]
        public string RefundDetailList { get; set; }

        /// <summary>
        /// 支付宝交易的总金额 单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝侧交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
