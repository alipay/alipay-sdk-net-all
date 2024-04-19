using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolRuleGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolRuleGetResponse : AopResponse
    {
        /// <summary>
        /// 额度指标  - Function_Counts  - Function_Resource_Usage  - Function_Data  - Database_Storage  - Read_Counts  - Write_Counts  - Oss_Capacity  - Oss_Data  - Oss_Download  - Oss_Upload  - Oss_Reverse_Data  - Staticsite_Capacity  - Staticsite_Data
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [XmlElement("fee_item_name")]
        public string FeeItemName { get; set; }

        /// <summary>
        /// 套餐额度
        /// </summary>
        [XmlElement("package_quota")]
        public string PackageQuota { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 阈值（比例）
        /// </summary>
        [XmlElement("threshold")]
        public long Threshold { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }
    }
}
