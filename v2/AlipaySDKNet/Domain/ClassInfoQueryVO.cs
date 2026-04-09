using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClassInfoQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class ClassInfoQueryVO : AopObject
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 结课日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 上课时间描述
        /// </summary>
        [XmlElement("schedule_description")]
        public string ScheduleDescription { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 开班日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
