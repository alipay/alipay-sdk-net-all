using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderBroadcastQueryModel : AopObject
    {
        /// <summary>
        /// 设备绑定开始时间与设备绑定结束时间间隔不得超过6个月，并且要么同时为空或者同时不为空
        /// </summary>
        [XmlElement("bind_end_date")]
        public string BindEndDate { get; set; }

        /// <summary>
        /// 设备绑定开始时间与设备绑定结束时间间隔不得超过6个月，并且要么同时为空或者同时不为空。当设备绑定开始与结束时间、激活开始与结束时间、碰激活开始与结束时间都为空时，默认查询绑定时间为六个月内的数据
        /// </summary>
        [XmlElement("bind_start_date")]
        public string BindStartDate { get; set; }

        /// <summary>
        /// 激活开始时间与激活结束时间间隔不得超过6个月，并且要么同时为空或者同时不为空
        /// </summary>
        [XmlElement("biz_active_end_time")]
        public string BizActiveEndTime { get; set; }

        /// <summary>
        /// 激活开始时间与激活结束时间间隔不得超过6个月，并且要么同时为空或者同时不为空
        /// </summary>
        [XmlElement("biz_active_start_time")]
        public string BizActiveStartTime { get; set; }

        /// <summary>
        /// 碰激活开始时间与碰激活结束时间间隔不得超过6个月，并且要么同时为空或者同时不为空
        /// </summary>
        [XmlElement("biz_touch_active_end_time")]
        public string BizTouchActiveEndTime { get; set; }

        /// <summary>
        /// 碰激活开始时间与碰激活结束时间间隔不得超过6个月，并且要么同时为空或者同时不为空
        /// </summary>
        [XmlElement("biz_touch_active_start_time")]
        public string BizTouchActiveStartTime { get; set; }

        /// <summary>
        /// 查询的作业截止日期，要求最近60天以内 当前字段已废弃(此字段已经废弃，传值不再生效，默认查询最新作业截止日期)
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 间联商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
