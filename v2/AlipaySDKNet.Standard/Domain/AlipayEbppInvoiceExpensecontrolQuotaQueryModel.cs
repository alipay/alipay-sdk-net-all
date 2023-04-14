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
        /// 企业共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 切换open_id前请使用：额度所属者ID owner_type为EMPLOYEE时为员工支付宝ID owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE_PAY_UID时为员工企业码ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：额度所属者ID owner_type为EMPLOYEE时为员工open_id owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE_PAY_UID时为员工企业码ID
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

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
        /// 额度ID 特殊说明：最多传入10个quota_id
        /// </summary>
        [XmlArray("quota_id_list")]
        [XmlArrayItem("string")]
        public List<string> QuotaIdList { get; set; }

        /// <summary>
        /// 额度维度ID 当 target_type=EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type=RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type=INSTITUTION 时，值为制度ID，target_type和target_id要正确对应，否则会导致查不到额度。
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）， INSTITUTION（制度维度）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
