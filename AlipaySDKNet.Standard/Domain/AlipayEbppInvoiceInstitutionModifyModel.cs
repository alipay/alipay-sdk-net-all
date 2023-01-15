using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id（条件必填）
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号（条件必填）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控咨询模式： 0-支付宝内部计算 1-咨询外部服务商
        /// </summary>
        [XmlElement("consult_mode")]
        public string ConsultMode { get; set; }

        /// <summary>
        /// 制度是否启用（可空），"0"为停用，"1"为启用
        /// </summary>
        [XmlElement("effective")]
        public string Effective { get; set; }

        /// <summary>
        /// 制度生效结束时间（可空），最小粒度为天，最早是当日
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 制度生效起始时间（可空），最小粒度为天，最早是当日
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业id（条件必填）
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 制度描述（可空）
        /// </summary>
        [XmlElement("institution_desc")]
        public string InstitutionDesc { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 制度名称（可空）
        /// </summary>
        [XmlElement("institution_name")]
        public string InstitutionName { get; set; }
    }
}
