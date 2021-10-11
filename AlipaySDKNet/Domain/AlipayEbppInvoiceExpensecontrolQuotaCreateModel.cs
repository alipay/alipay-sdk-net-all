using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolQuotaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolQuotaCreateModel : AopObject
    {
        /// <summary>
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 额度失效时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 额度所属者ID owner_type为EMPLOYEE时为员工支付宝ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 额度所属者类型 EMPLOYEE: 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 额度限制（分） 限额：100000元
        /// </summary>
        [XmlElement("quota_value")]
        public string QuotaValue { get; set; }

        /// <summary>
        /// 额度类型ID MEAL: 工作餐
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度类型 EXPENSE_TYPE: 费用类型额度
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
