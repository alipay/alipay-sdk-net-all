using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowSubaccountCreateResponse : AopResponse
    {
        /// <summary>
        /// mode为浦发银行且开户成功时返回,按余额出金时使用
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 母户的账户名称
        /// </summary>
        [XmlElement("bank_cert_name")]
        public string BankCertName { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 网商银行的银行联号
        /// </summary>
        [XmlElement("branch_no")]
        public string BranchNo { get; set; }

        /// <summary>
        /// mode为浦发银行且开户成功时返回
        /// </summary>
        [XmlElement("corporate_settlement_card")]
        public string CorporateSettlementCard { get; set; }

        /// <summary>
        /// mode为浦发银行且开户成功时必填
        /// </summary>
        [XmlElement("sub_account_name")]
        public string SubAccountName { get; set; }

        /// <summary>
        /// 商户需要保存下来。销户时，与out_user_id一起传入销户
        /// </summary>
        [XmlElement("sub_bank_card_no")]
        public string SubBankCardNo { get; set; }
    }
}
