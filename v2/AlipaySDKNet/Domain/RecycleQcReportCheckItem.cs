using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportCheckItem Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportCheckItem : AopObject
    {
        /// <summary>
        /// 是否和用户反馈一致
        /// </summary>
        [XmlElement("is_consistent")]
        public bool IsConsistent { get; set; }

        /// <summary>
        /// 商户质检结果
        /// </summary>
        [XmlElement("merchant_check_result")]
        public RecycleQcReportResult MerchantCheckResult { get; set; }

        /// <summary>
        /// 用户质检结果
        /// </summary>
        [XmlElement("user_self_check_result")]
        public RecycleQcReportResult UserSelfCheckResult { get; set; }
    }
}
