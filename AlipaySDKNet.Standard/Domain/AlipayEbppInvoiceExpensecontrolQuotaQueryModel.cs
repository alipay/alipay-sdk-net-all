using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolQuotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolQuotaQueryModel : AopObject
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
        /// 额度所属者ID owner_type为员工时为员工支付宝ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 额度所属者类型 EMPLOYEE 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，限制20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 额度ID 最大长度：10
        /// </summary>
        [XmlArray("quota_id_list")]
        [XmlArrayItem("string")]
        public List<string> QuotaIdList { get; set; }

        /// <summary>
        /// 额度类型ID MEAL: 工作餐
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度类型 EXPENSE_TYPE: 场景盖帽额度
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
