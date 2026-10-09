using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalTradeQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 医保个账支付金额
        /// </summary>
        [XmlElement("account_amount")]
        public string AccountAmount { get; set; }

        /// <summary>
        /// 支付宝交易流水号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 商户门店对应的收单银行ID
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 商户门店对应的收单银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行订单号
        /// </summary>
        [XmlElement("bank_order_id")]
        public string BankOrderId { get; set; }

        /// <summary>
        /// 即医院上传处方明细的收费批次号
        /// </summary>
        [XmlElement("chrg_bch_no")]
        public string ChrgBchNo { get; set; }

        /// <summary>
        /// 医保支付成功时间
        /// </summary>
        [XmlElement("gmt_medical_paid")]
        public string GmtMedicalPaid { get; set; }

        /// <summary>
        /// 商户创单时间
        /// </summary>
        [XmlElement("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 自费支付成功时间
        /// </summary>
        [XmlElement("gmt_own_paid")]
        public string GmtOwnPaid { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 医保基金支付金额
        /// </summary>
        [XmlElement("gov_amount")]
        public string GovAmount { get; set; }

        /// <summary>
        /// 医院支付订单号
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 医保支付状态描述
        /// </summary>
        [XmlElement("medical_pay_msg")]
        public string MedicalPayMsg { get; set; }

        /// <summary>
        /// 医保支付状态
        /// </summary>
        [XmlElement("medical_pay_status")]
        public string MedicalPayStatus { get; set; }

        /// <summary>
        /// 请求移动支付中心返回的“重定向完成医保结算确认地址”
        /// </summary>
        [XmlElement("nathsa_direct_url")]
        public string NathsaDirectUrl { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 新国标定点医药机构编码
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 医保其他支付金额
        /// </summary>
        [XmlElement("other_amount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// 该笔交易对应的外部交易流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 自费支付状态描述
        /// </summary>
        [XmlElement("own_pay_msg")]
        public string OwnPayMsg { get; set; }

        /// <summary>
        /// 自费交易状态
        /// </summary>
        [XmlElement("own_pay_status")]
        public string OwnPayStatus { get; set; }

        /// <summary>
        /// 医保订单号
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 用户自费实付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 已退款总金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 订单支付类型
        /// </summary>
        [XmlElement("rels_pay_flag")]
        public string RelsPayFlag { get; set; }

        /// <summary>
        /// 如果是亲情账户支付，会返回主账户脱敏姓名
        /// </summary>
        [XmlElement("rels_pay_user_name")]
        public string RelsPayUserName { get; set; }

        /// <summary>
        /// 补充描述
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 医保数据请求透传结构体
        /// </summary>
        [XmlElement("request_content")]
        public string RequestContent { get; set; }

        /// <summary>
        /// 医保数据返回透传结构体
        /// </summary>
        [XmlElement("response_content")]
        public string ResponseContent { get; set; }

        /// <summary>
        /// 平台分配给商户的门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 补充计算金额参数列表
        /// </summary>
        [XmlArray("subsidy_amount_params")]
        [XmlArrayItem("subsidy_amount_param")]
        public List<SubsidyAmountParam> SubsidyAmountParams { get; set; }

        /// <summary>
        /// 交易总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易总状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
