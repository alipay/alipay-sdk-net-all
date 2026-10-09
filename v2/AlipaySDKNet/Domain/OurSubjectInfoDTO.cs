using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OurSubjectInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OurSubjectInfoDTO : AopObject
    {
        /// <summary>
        /// 行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("deposit_bank")]
        public string DepositBank { get; set; }

        /// <summary>
        /// 我方公司id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 提交人
        /// </summary>
        [XmlElement("operator")]
        public AlcollectioncenterUserDTO Operator { get; set; }

        /// <summary>
        /// ouCode
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 我方收款银行账户
        /// </summary>
        [XmlElement("our_bank_account")]
        public string OurBankAccount { get; set; }

        /// <summary>
        /// 业务所属BU
        /// </summary>
        [XmlElement("our_biz_bu")]
        public string OurBizBu { get; set; }

        /// <summary>
        /// 我方业务负责人
        /// </summary>
        [XmlElement("our_biz_principal")]
        public AlcollectioncenterUserDTO OurBizPrincipal { get; set; }

        /// <summary>
        /// 我方联系人邮箱
        /// </summary>
        [XmlElement("our_contact_email")]
        public string OurContactEmail { get; set; }

        /// <summary>
        /// 我方联系人姓名
        /// </summary>
        [XmlElement("our_contact_name")]
        public string OurContactName { get; set; }

        /// <summary>
        /// 我方联系人工号
        /// </summary>
        [XmlElement("our_contact_no")]
        public string OurContactNo { get; set; }

        /// <summary>
        /// 我方联系人电话
        /// </summary>
        [XmlElement("our_contact_phone")]
        public string OurContactPhone { get; set; }

        /// <summary>
        /// 我方财务负责人
        /// </summary>
        [XmlElement("our_finance_principal")]
        public AlcollectioncenterUserDTO OurFinancePrincipal { get; set; }

        /// <summary>
        /// 我方业中台负责人
        /// </summary>
        [XmlElement("our_middle_ground_principal")]
        public AlcollectioncenterUserDTO OurMiddleGroundPrincipal { get; set; }

        /// <summary>
        /// 我方收款户名
        /// </summary>
        [XmlElement("our_payee_account_name")]
        public string OurPayeeAccountName { get; set; }

        /// <summary>
        /// 我方结算负责人
        /// </summary>
        [XmlElement("our_settle_principal")]
        public AlcollectioncenterUserDTO OurSettlePrincipal { get; set; }

        /// <summary>
        /// 我方主体
        /// </summary>
        [XmlElement("our_subject")]
        public string OurSubject { get; set; }

        /// <summary>
        /// 我方主体id
        /// </summary>
        [XmlElement("our_subject_id")]
        public string OurSubjectId { get; set; }
    }
}
