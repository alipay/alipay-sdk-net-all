using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpPackSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpPackSubscribeModel : AopObject
    {
        /// <summary>
        /// 合作方用户编号
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 订阅结束时间。格式yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 套餐类别
        /// </summary>
        [XmlElement("pack_type")]
        public string PackType { get; set; }

        /// <summary>
        /// 订阅额度。单位个、次
        /// </summary>
        [XmlElement("quota")]
        public long Quota { get; set; }

        /// <summary>
        /// 订阅价格
        /// </summary>
        [XmlElement("report_amount")]
        public string ReportAmount { get; set; }

        /// <summary>
        /// 订阅开始时间。格式yyyy-MM-dd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
