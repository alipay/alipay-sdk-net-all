using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountQuotaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountQuotaDTO : AopObject
    {
        /// <summary>
        /// 自定义周期起始日期，精确到分钟，yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("custom_begin_date")]
        public string CustomBeginDate { get; set; }

        /// <summary>
        /// 自定义周期结束日期，精确到分钟，yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("custom_end_date")]
        public string CustomEndDate { get; set; }

        /// <summary>
        /// 额度维度 日：DAY 月：MONTH 年：YEAR 终身：LIFETIME 自定义周期：CUSTOMIZED，需要传自定义周期时间区间
        /// </summary>
        [XmlElement("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        [XmlElement("quota_total")]
        public string QuotaTotal { get; set; }
    }
}
