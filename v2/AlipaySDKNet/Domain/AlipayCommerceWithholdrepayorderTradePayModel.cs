using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderTradePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdrepayorderTradePayModel : AopObject
    {
        /// <summary>
        /// 代扣信息。 代扣业务需要传入的协议相关信息，使用本参数传入协议号后scene和auth_code不需要再传值。
        /// </summary>
        [XmlElement("agreement_params")]
        public AgreementParams AgreementParams { get; set; }

        /// <summary>
        /// 业务扩展参数，二级参数字段会动态新增
        /// </summary>
        [XmlElement("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式。
        /// </summary>
        [XmlElement("goods_detail")]
        public GoodsDetail GoodsDetail { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付相关参数
        /// </summary>
        [XmlElement("pay_params")]
        public IndustryPayParams PayParams { get; set; }

        /// <summary>
        /// 产品码。 商家和支付宝签约的产品码。 注意：本参数必填，且固定值为GENERAL_WITHHOLDING。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠明细参数，通过此属性补充营销参数
        /// </summary>
        [XmlElement("promo_params")]
        public IndustryPromoParam PromoParams { get; set; }

        /// <summary>
        /// 返回参数选项。 商户通过传递该参数来定制同步需要额外返回的信息字段，数组格式。包括但不限于：["fund_bill_list","voucher_detail_list","enterprise_pay_info","discount_goods_detail","discount_amount","mdiscount_amount"]
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 扣款条目，传入对应还款计划的扣款信息
        /// </summary>
        [XmlArray("repay_plan")]
        [XmlArrayItem("industry_withhold_plan_d_t_o")]
        public List<IndustryWithholdPlanDTO> RepayPlan { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户>请求传入的seller_id>商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系； 支付宝预授权和新当面资金授权场景下必填。
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
