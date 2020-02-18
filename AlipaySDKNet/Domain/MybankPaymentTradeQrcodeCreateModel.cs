using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 账户分类 对私 private；对公 public
        /// </summary>
        [XmlElement("account_category")]
        public string AccountCategory { get; set; }

        /// <summary>
        /// 账户类型 外部卡：OUT_BANK，云资金账号：CLOUND_ACCOUNT  网商银行卡：  MYBANK
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 订单金额 动态码场景必填，金额分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 业务订单单号  动态码场景必填
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 开户行的联行号
        /// </summary>
        [XmlElement("branch_inst_code")]
        public string BranchInstCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 渠道 开放平台openPlatform 金蝉平台 jinChan
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 币种 默认是CNY，动态码场景选填
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 企业方案合约号
        /// </summary>
        [XmlElement("enterprise_scheme_ar_no")]
        public string EnterpriseSchemeArNo { get; set; }

        /// <summary>
        /// 总行联行号
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 失效时间  yyyy-MM-dd HH:mm:ss格式的
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 订单扩展字段 JSON格式，UTF-8编码
        /// </summary>
        [XmlElement("order_ext")]
        public string OrderExt { get; set; }

        /// <summary>
        /// 个人方案合约号
        /// </summary>
        [XmlElement("personal_scheme_ar_no")]
        public string PersonalSchemeArNo { get; set; }

        /// <summary>
        /// 二维码类型 DYNAMIC_CODE STATIC_COD
        /// </summary>
        [XmlElement("qr_code_type")]
        public string QrCodeType { get; set; }

        /// <summary>
        /// 收款银行账户的名称
        /// </summary>
        [XmlElement("receipt_account_name")]
        public string ReceiptAccountName { get; set; }

        /// <summary>
        /// 收款银行卡号
        /// </summary>
        [XmlElement("receipt_account_no")]
        public string ReceiptAccountNo { get; set; }
    }
}
