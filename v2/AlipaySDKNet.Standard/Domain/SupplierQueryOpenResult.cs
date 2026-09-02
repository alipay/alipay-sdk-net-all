using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierQueryOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierQueryOpenResult : AopObject
    {
        /// <summary>
        /// 支付宝账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 收款银行卡号（已脱敏）
        /// </summary>
        [XmlElement("bank_card_no_masked")]
        public string BankCardNoMasked { get; set; }

        /// <summary>
        /// 供应商收款银行编码
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 供应商收款银行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 是否维护供应商收款银行卡
        /// </summary>
        [XmlElement("has_bank_card")]
        public string HasBankCard { get; set; }

        /// <summary>
        /// 供应商支付宝账号
        /// </summary>
        [XmlElement("supplier_account_no")]
        public string SupplierAccountNo { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 供应商姓名
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 供应商联系电话
        /// </summary>
        [XmlElement("supplier_phone")]
        public string SupplierPhone { get; set; }

        /// <summary>
        /// 供应商状态
        /// </summary>
        [XmlElement("supplier_status")]
        public string SupplierStatus { get; set; }
    }
}
