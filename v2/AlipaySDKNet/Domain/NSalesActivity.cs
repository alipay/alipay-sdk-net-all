using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NSalesActivity Data Structure.
    /// </summary>
    [Serializable]
    public class NSalesActivity : AopObject
    {
        /// <summary>
        /// 卖进活动设备编号
        /// </summary>
        [XmlElement("activity_dvc_sn")]
        public string ActivityDvcSn { get; set; }

        /// <summary>
        /// 卖进订单活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 卖进订单活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 卖进订单活动创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 卖进订单活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 卖进订单子活动列表
        /// </summary>
        [XmlArray("period_list")]
        [XmlArrayItem("n_sales_sub_activity")]
        public List<NSalesSubActivity> PeriodList { get; set; }

        /// <summary>
        /// 卖进订单活动跳过日期，未配置跳过日期时不返回该字段。
        /// </summary>
        [XmlArray("skip_dates")]
        [XmlArrayItem("date")]
        public List<string> SkipDates { get; set; }

        /// <summary>
        /// 卖进订单活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 卖进订单活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
