using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolRuleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseQuotacontrolRuleCreateModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 额度指标  - Function_Counts  - Function_Resource_Usage  - Function_Data  - Database_Storage  - Read_Counts  - Write_Counts  - Oss_Capacity  - Oss_Data  - Oss_Download  - Oss_Upload  - Oss_Reverse_Data  - Staticsite_Capacity  - Staticsite_Data
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 阈值（比例）
        /// </summary>
        [XmlElement("threshold")]
        public long Threshold { get; set; }
    }
}
