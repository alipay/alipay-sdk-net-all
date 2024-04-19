using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IncomeDistributionTransInInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IncomeDistributionTransInInfo : AopObject
    {
        /// <summary>
        /// 收益分配的百分比数值，支持2位小数
        /// </summary>
        [XmlElement("allocate_rate")]
        public string AllocateRate { get; set; }

        /// <summary>
        /// 收款方类型为「03-外部银行账户」时必填
        /// </summary>
        [XmlElement("bank_branch_code")]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// 收款方类型为「03-外部银行账户」时必填.
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 收款方类型为「04-标准数币钱包」时必填 C1010211000012 工行 C1010311000014 衣行 C1010411000013 中行 C1010511003703 建行 Z2004944000010 腾讯-财付通 C1302533000018 浙江网商银行 C1040311005293 邮储 C1030131001288 交通银行 C1030844001362 招行 C1030935001347 兴业银行
        /// </summary>
        [XmlElement("digit_currency_inst")]
        public string DigitCurrencyInst { get; set; }

        /// <summary>
        /// 当收款方类型为「01-子户/子钱包」时，需填写子户（子钱包）ID 当收款方账户类型为「02-支付宝」时，为支付宝身份标识id 当收款方账户类型为「03-外部银行账户」时，为银行账户账号 当收款方账户类型为「04-标准数币钱包」时，为数币钱包id
        /// </summary>
        [XmlElement("trans_in_account_no")]
        public string TransInAccountNo { get; set; }

        /// <summary>
        /// 当收款方账户类型 01-子户/子钱包 02-支付宝账户 03-外部银行账户 04-标准数币钱包
        /// </summary>
        [XmlElement("trans_in_account_type")]
        public string TransInAccountType { get; set; }

        /// <summary>
        /// 收款方证件号，如企业证件号码
        /// </summary>
        [XmlElement("trans_in_cert_no")]
        public string TransInCertNo { get; set; }

        /// <summary>
        /// 证件类型。 01-统一社会信用编码 02-居民身份证
        /// </summary>
        [XmlElement("trans_in_cert_type")]
        public string TransInCertType { get; set; }

        /// <summary>
        /// 收益分配收款方，需和证件号、收款账户对应名称一致
        /// </summary>
        [XmlElement("trans_in_name")]
        public string TransInName { get; set; }
    }
}
