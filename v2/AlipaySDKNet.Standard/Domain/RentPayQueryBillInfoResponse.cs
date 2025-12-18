using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayQueryBillInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayQueryBillInfoResponse : AopObject
    {
        /// <summary>
        /// 公积金支付返回
        /// </summary>
        [XmlElement("accfund_result")]
        public string AccfundResult { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [XmlElement("application_date")]
        public string ApplicationDate { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_num")]
        public string CertNum { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 提取利息，单位：元
        /// </summary>
        [XmlElement("draw_interest")]
        public string DrawInterest { get; set; }

        /// <summary>
        /// 提取原因
        /// </summary>
        [XmlElement("draw_item")]
        public string DrawItem { get; set; }

        /// <summary>
        /// 提取本金，单位：元
        /// </summary>
        [XmlElement("draw_principal")]
        public string DrawPrincipal { get; set; }

        /// <summary>
        /// 支付日期
        /// </summary>
        [XmlElement("payment_date")]
        public string PaymentDate { get; set; }

        /// <summary>
        /// 提取资金支付状态
        /// </summary>
        [XmlElement("payment_state")]
        public string PaymentState { get; set; }

        /// <summary>
        /// 本息合计，单位：元
        /// </summary>
        [XmlElement("principal_interest_total")]
        public string PrincipalInterestTotal { get; set; }

        /// <summary>
        /// 中国人民银行国家金库
        /// </summary>
        [XmlElement("recipient_bank_code")]
        public string RecipientBankCode { get; set; }

        /// <summary>
        /// 转入账号
        /// </summary>
        [XmlElement("recipient_bank_num")]
        public string RecipientBankNum { get; set; }

        /// <summary>
        /// 转入户名
        /// </summary>
        [XmlElement("recipient_bank_username")]
        public string RecipientBankUsername { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 签约用户在公积金侧的备案编号
        /// </summary>
        [XmlElement("user_record_no")]
        public string UserRecordNo { get; set; }
    }
}
