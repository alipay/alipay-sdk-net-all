using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceApplyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceApplyDTO : AopObject
    {
        /// <summary>
        /// 合计金额（申请开票总金额，含税） 格式为2位小数
        /// </summary>
        [XmlElement("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 开票申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 该申请批次对应的实际账单对应结束时间
        /// </summary>
        [XmlElement("gmt_biz_end")]
        public string GmtBizEnd { get; set; }

        /// <summary>
        /// 该申请批次对应的实际账单对应起始时间
        /// </summary>
        [XmlElement("gmt_biz_start")]
        public string GmtBizStart { get; set; }

        /// <summary>
        /// 开票（介质）类型 可选值： 0: 电票 1：纸质普票 2：纸质专票 3：电子专票
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票（文件）类型 可选值： blue: 蓝票 red: 红票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购方地址
        /// </summary>
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("payer_bank_account_id")]
        public string PayerBankAccountId { get; set; }

        /// <summary>
        /// 购方开户行名称
        /// </summary>
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购方电子邮箱，需满足邮箱格式。
        /// </summary>
        [XmlElement("payer_email")]
        public string PayerEmail { get; set; }

        /// <summary>
        /// 购方抬头
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [XmlElement("payer_phone")]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 购方方税务登记证号，由大写字母或数字组成，长度要求15~20位。
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 购方手机号码，用于短信通知收票。 格式为11位数字组成的手机号码
        /// </summary>
        [XmlElement("recieve_mobile")]
        public string RecieveMobile { get; set; }
    }
}
