using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRecruitMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRecruitMessageSendModel : AopObject
    {
        /// <summary>
        /// 场景，上班打卡提醒=CLOCK_IN_REMINDER
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_apply_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutApplyIdList { get; set; }

        /// <summary>
        /// 外部岗位id
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// B端的岗位详情URL
        /// </summary>
        [XmlElement("server_job_url")]
        public string ServerJobUrl { get; set; }

        /// <summary>
        /// 上班开始剩余时间，枚举：15min、1H
        /// </summary>
        [XmlElement("surplus_time")]
        public string SurplusTime { get; set; }
    }
}
