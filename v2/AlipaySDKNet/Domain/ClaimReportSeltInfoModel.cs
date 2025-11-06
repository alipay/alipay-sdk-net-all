using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimReportSeltInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimReportSeltInfoModel : AopObject
    {
        /// <summary>
        /// 医保个账支付金额 单位：元，留俩位小数
        /// </summary>
        [XmlElement("acct_pay_amount")]
        public string AcctPayAmount { get; set; }

        /// <summary>
        /// 入院日期
        /// </summary>
        [XmlElement("admission_date")]
        public string AdmissionDate { get; set; }

        /// <summary>
        /// 自费支付金额 单位：元，留俩位小数
        /// </summary>
        [XmlElement("cash_pay_amount")]
        public string CashPayAmount { get; set; }

        /// <summary>
        /// 出院日期
        /// </summary>
        [XmlElement("discharge_ate")]
        public string DischargeAte { get; set; }

        /// <summary>
        /// 医保统筹支付金额 单位：元，留俩位小数
        /// </summary>
        [XmlElement("hifp_pay_amout")]
        public string HifpPayAmout { get; set; }

        /// <summary>
        /// 就诊ID
        /// </summary>
        [XmlElement("inquery_id")]
        public string InqueryId { get; set; }

        /// <summary>
        /// 医疗类别
        /// </summary>
        [XmlElement("med_type")]
        public string MedType { get; set; }

        /// <summary>
        /// 支付总金额 单位：元，留俩位小数
        /// </summary>
        [XmlElement("medfee_sumamt")]
        public string MedfeeSumamt { get; set; }

        /// <summary>
        /// 就诊医院ID
        /// </summary>
        [XmlElement("medical_org_id")]
        public string MedicalOrgId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("medical_org_name")]
        public string MedicalOrgName { get; set; }

        /// <summary>
        /// 机构类型
        /// </summary>
        [XmlElement("medins_type_name")]
        public string MedinsTypeName { get; set; }

        /// <summary>
        /// 其他基金支付金额 单位：元，留俩位小数
        /// </summary>
        [XmlElement("othfund_pay_amount")]
        public string OthfundPayAmount { get; set; }

        /// <summary>
        /// 个人自付金额 单位：元，留俩位小数
        /// </summary>
        [XmlElement("self_pay_amount")]
        public string SelfPayAmount { get; set; }

        /// <summary>
        /// 结算时间
        /// </summary>
        [XmlElement("selt_time")]
        public string SeltTime { get; set; }

        /// <summary>
        /// 医保结算单号
        /// </summary>
        [XmlElement("setl_id")]
        public string SetlId { get; set; }
    }
}
