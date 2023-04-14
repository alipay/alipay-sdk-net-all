using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPaymentCreateandpayModel : AopObject
    {
        /// <summary>
        /// 个人账户支付金额
        /// </summary>
        [XmlElement("account_amount")]
        public string AccountAmount { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付回调地址
        /// </summary>
        [XmlElement("call_url")]
        public string CallUrl { get; set; }

        /// <summary>
        /// 国标移动支付间连下单扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public TradeExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 医疗机构下单时间
        /// </summary>
        [XmlElement("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 医保基金支付金额
        /// </summary>
        [XmlElement("gov_amount")]
        public string GovAmount { get; set; }

        /// <summary>
        /// 医院订单号(商户需保证appId维度唯一)
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 定点医疗机构编码
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 第三方平台商单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付授权码（用户授权给定点医药机构线上业务时取得）
        /// </summary>
        [XmlElement("pay_auth_no")]
        public string PayAuthNo { get; set; }

        /// <summary>
        /// 支付订单号（处方上传的出参订单号）
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 医保结算地国标城市编码
        /// </summary>
        [XmlElement("payment_city_code")]
        public string PaymentCityCode { get; set; }

        /// <summary>
        /// 现金支付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝侧交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
