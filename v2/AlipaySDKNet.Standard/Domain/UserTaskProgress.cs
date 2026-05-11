using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserTaskProgress Data Structure.
    /// </summary>
    [Serializable]
    public class UserTaskProgress : AopObject
    {
        /// <summary>
        /// 天天减活动进度日期
        /// </summary>
        [XmlElement("progress_time")]
        public string ProgressTime { get; set; }

        /// <summary>
        /// 天天减活动期间，用户有参与核销金额，单位：分
        /// </summary>
        [XmlElement("use_discount_amount")]
        public long UseDiscountAmount { get; set; }

        /// <summary>
        /// 天天减活动期间核销状态，有已核销、未核销、待使用三种状态
        /// </summary>
        [XmlElement("use_status")]
        public string UseStatus { get; set; }
    }
}
