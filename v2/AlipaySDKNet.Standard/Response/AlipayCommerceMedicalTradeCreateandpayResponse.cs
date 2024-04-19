using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalTradeCreateandpayResponse.
    /// </summary>
    public class AlipayCommerceMedicalTradeCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 自费创单后支付宝返回的支付宝交易流水号 (有自费部分时返回)
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 商户门店对应的收单银行ID (有自费部分时返回)
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 商户门店对应的收单银行名称 (有自费部分时返回)
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行订单号,有自费部分时该字段有值
        /// </summary>
        [XmlElement("bank_order_id")]
        public string BankOrderId { get; set; }

        /// <summary>
        /// 医院上传处方明细的收费批次号 (order_type=INSURANCE_PAY时必填)
        /// </summary>
        [XmlElement("chrg_bch_no")]
        public string ChrgBchNo { get; set; }

        /// <summary>
        /// 医院订单号
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 创建交易时商户传入的订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 该笔交易商户传入的外部交易流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 医保订单号 (order_type=INSURANCE_PAY返回)
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付跳转地址
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 医保支付类型
        /// </summary>
        [XmlElement("rels_pay_flag")]
        public string RelsPayFlag { get; set; }

        /// <summary>
        /// 如果是亲情账户授权，会返回主账户脱敏姓名 (亲情账户支付时返回)
        /// </summary>
        [XmlElement("rels_pay_user_name")]
        public string RelsPayUserName { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
