using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriceSubsidyData Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriceSubsidyData : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 失败的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 就诊编号
        /// </summary>
        [XmlElement("mdtrt_id")]
        public string MdtrtId { get; set; }

        /// <summary>
        /// 密算数据
        /// </summary>
        [XmlElement("ms_data")]
        public EnterpriceSubsidyMsData MsData { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 冲减金额
        /// </summary>
        [XmlElement("offset_amount")]
        public string OffsetAmount { get; set; }

        /// <summary>
        /// 支付宝转账订单号（失败时不传
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 账户类型是alipay时：支付宝用户名（邮箱、手机号） 账户类型是bankcard时：银行卡号
        /// </summary>
        [XmlElement("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 账户类型（alipay/bankcard）
        /// </summary>
        [XmlElement("pay_account_type")]
        public string PayAccountType { get; set; }

        /// <summary>
        /// 拨付金额 + 冲抵金额 = 密算里边计算出来的拨付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 拨付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 医保结算单号
        /// </summary>
        [XmlElement("setl_id")]
        public string SetlId { get; set; }

        /// <summary>
        /// 转账成功：success 转账失败：fail 未开始：pending
        /// </summary>
        [XmlElement("transfer_result")]
        public string TransferResult { get; set; }
    }
}
