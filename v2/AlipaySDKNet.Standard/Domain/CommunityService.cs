using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityService Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityService : AopObject
    {
        /// <summary>
        /// 跳转至服务商物业户号查询服务地址
        /// </summary>
        [XmlElement("billkey_url")]
        public string BillkeyUrl { get; set; }

        /// <summary>
        /// 每日服务结束时间。精度：分钟
        /// </summary>
        [XmlElement("daily_end")]
        public string DailyEnd { get; set; }

        /// <summary>
        /// 每日服务开始时间。精度：分钟
        /// </summary>
        [XmlElement("daily_start")]
        public string DailyStart { get; set; }

        /// <summary>
        /// 访问服务商侧服务账单的跳转地址
        /// </summary>
        [XmlElement("out_bill_url")]
        public string OutBillUrl { get; set; }

        /// <summary>
        /// 当前小区开通办理业务
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
