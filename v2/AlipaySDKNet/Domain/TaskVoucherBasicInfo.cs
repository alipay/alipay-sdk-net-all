using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskVoucherBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskVoucherBasicInfo : AopObject
    {
        /// <summary>
        /// 券图标
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 代金券面额
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 门槛金额
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 总核销次数
        /// </summary>
        [XmlElement("total_used_count")]
        public long TotalUsedCount { get; set; }

        /// <summary>
        /// 门店核销次数
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 任务模板编号
        /// </summary>
        [XmlElement("voucher_template_no")]
        public string VoucherTemplateNo { get; set; }
    }
}
