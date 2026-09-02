using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmStagereportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmStagereportQueryModel : AopObject
    {
        /// <summary>
        /// 活动 ID，不传则查用户当前有效活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 渠道，HM_HEALTH_ACTIVITY(家空间健康活动)
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 查询结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 用户openid 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 报告类型WEEKLY/MONTHLY/FINAL/ALL
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 查询开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("user_uid")]
        public string UserUid { get; set; }
    }
}
