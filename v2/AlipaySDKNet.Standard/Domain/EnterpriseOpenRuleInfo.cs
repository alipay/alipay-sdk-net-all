using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseOpenRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseOpenRuleInfo : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 当前生效和下次生效的开票规则记录
        /// </summary>
        [XmlArray("enterprise_open_rule_record_info_list")]
        [XmlArrayItem("enterprise_open_rule_record_info")]
        public List<EnterpriseOpenRuleRecordInfo> EnterpriseOpenRuleRecordInfoList { get; set; }

        /// <summary>
        /// 开票规则绑定关系
        /// </summary>
        [XmlArray("enterprise_open_rule_relation_info_list")]
        [XmlArrayItem("enterprise_open_rule_relation_info")]
        public List<EnterpriseOpenRuleRelationInfo> EnterpriseOpenRuleRelationInfoList { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 开票规则id
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 开票规则名称
        /// </summary>
        [XmlElement("invoice_rule_name")]
        public string InvoiceRuleName { get; set; }

        /// <summary>
        /// 原企业共同账户ID（不推荐使用）
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 销方类型：TP开票、商户开票、商户优先 枚举定义：MERCHANT（商户）、TP（TP）、MERCHANT_TP（商户优先，本期不支持）
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }
    }
}
