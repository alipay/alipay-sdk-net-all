using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalPaymentQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalPaymentQueryResponse : AopObject
    {
        /// <summary>
        /// 医保个账支付金额
        /// </summary>
        [XmlElement("account_amount")]
        public string AccountAmount { get; set; }

        /// <summary>
        /// 下单接口返回的渠道订单流水号
        /// </summary>
        [XmlElement("chnl_ord_sn")]
        public string ChnlOrdSn { get; set; }

        /// <summary>
        /// 医保支付失败原因描述
        /// </summary>
        [XmlElement("error_reason")]
        public string ErrorReason { get; set; }

        /// <summary>
        /// 医疗机构下单时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 支付完成时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_paid")]
        public string GmtPaid { get; set; }

        /// <summary>
        /// 医保统筹支付金额
        /// </summary>
        [XmlElement("gov_amount")]
        public string GovAmount { get; set; }

        /// <summary>
        /// 医保补充计算金额
        /// </summary>
        [XmlElement("insurance_subsidy_amount")]
        public string InsuranceSubsidyAmount { get; set; }

        /// <summary>
        /// 医保补充计算方式
        /// </summary>
        [XmlElement("insurance_subsidy_mode")]
        public string InsuranceSubsidyMode { get; set; }

        /// <summary>
        /// 医院订单号（商户需保证appId维度唯一）
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 医保支付状态，详见医保退款状态查询接口返回结果
        /// </summary>
        [XmlElement("medical_pay_status")]
        public string MedicalPayStatus { get; set; }

        /// <summary>
        /// 医保退款金额
        /// </summary>
        [XmlElement("medical_refund_amount")]
        public string MedicalRefundAmount { get; set; }

        /// <summary>
        /// 支付宝小程序Id
        /// </summary>
        [XmlElement("openapi_app_id")]
        public string OpenapiAppId { get; set; }

        /// <summary>
        /// 定点医疗机构编码,P/H+11位数字
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 医保支付其他金额
        /// </summary>
        [XmlElement("other_amount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// 第三方平台商单号,取值为商户在下单接口中传入的out_trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝侧自费交易单状态
        /// </summary>
        [XmlElement("own_pay_status")]
        public string OwnPayStatus { get; set; }

        /// <summary>
        /// 支付订单号（处方上传的出参订单号）
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 订单使用的支付方式描述，MEDICAL_PAYMENT表示医保支付，MIXED_PAYMENT表示混合支付
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 用户自费支付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 自费退款金额
        /// </summary>
        [XmlElement("real_refund_amount")]
        public string RealRefundAmount { get; set; }

        /// <summary>
        /// 补充字段描述
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 医疗机构透传体
        /// </summary>
        [XmlElement("request_content")]
        public string RequestContent { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝侧自费交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
