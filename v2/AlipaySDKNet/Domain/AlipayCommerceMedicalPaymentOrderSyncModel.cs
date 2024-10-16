using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPaymentOrderSyncModel : AopObject
    {
        /// <summary>
        /// 使用支付宝支付的金额
        /// </summary>
        [XmlElement("alipay_amount")]
        public string AlipayAmount { get; set; }

        /// <summary>
        /// 一码付自费部分的支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 医保核心的业务流水号
        /// </summary>
        [XmlArray("biz_trace_no")]
        [XmlArrayItem("string")]
        public List<string> BizTraceNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 医保单总金额；币种：人民币；单位：元；
        /// </summary>
        [XmlElement("fee_sumamt")]
        public string FeeSumamt { get; set; }

        /// <summary>
        /// 医保统筹基金支付金额；币种：人民币；单位：元；
        /// </summary>
        [XmlElement("fund_pay")]
        public string FundPay { get; set; }

        /// <summary>
        /// 支付完成时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_paid")]
        public string GmtPaid { get; set; }

        /// <summary>
        /// 定点医药机构编码名称，请勿传入空格、换行等特殊符号；请注意字符编码以防止中文乱码
        /// </summary>
        [XmlElement("medical_org_name")]
        public string MedicalOrgName { get; set; }

        /// <summary>
        /// 国家医保局标准的定点医药机构编码；格式为1位字母+11位数字
        /// </summary>
        [XmlElement("medical_org_no")]
        public string MedicalOrgNo { get; set; }

        /// <summary>
        /// 支付
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }

        /// <summary>
        /// 非支付宝支付的金额的信息
        /// </summary>
        [XmlArray("other_pay_channel")]
        [XmlArrayItem("medical_order_pay_channel")]
        public List<MedicalOrderPayChannel> OtherPayChannel { get; set; }

        /// <summary>
        /// 商户侧的唯一的业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 医保试算后，需用户自费现金支付的金额；币种：人民币；单位：元；
        /// </summary>
        [XmlElement("own_pay_amt")]
        public string OwnPayAmt { get; set; }

        /// <summary>
        /// 就医所在地城市编码，需传入国家标准行政区划编码
        /// </summary>
        [XmlElement("payment_city_code")]
        public string PaymentCityCode { get; set; }

        /// <summary>
        /// 订单支付的场景标识
        /// </summary>
        [XmlElement("payment_place")]
        public string PaymentPlace { get; set; }

        /// <summary>
        /// 支付场景编号，如收费窗口的编号、自助机的设备号等
        /// </summary>
        [XmlElement("payment_place_code")]
        public string PaymentPlaceCode { get; set; }

        /// <summary>
        /// 医保个人账户支付金额；币种：人民币；单位：元；
        /// </summary>
        [XmlElement("psn_acct_pay")]
        public string PsnAcctPay { get; set; }

        /// <summary>
        /// 电子凭证码值或终端刷脸返回码值，28位长度，以424或ano开头
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 订单状态；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 描述订单内容
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 系统服务商的PartnerId
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
