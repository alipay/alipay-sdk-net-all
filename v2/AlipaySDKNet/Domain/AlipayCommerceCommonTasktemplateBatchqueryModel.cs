using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTasktemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询时间范围结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 出资方id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 代运营商户的id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 活动方id
        /// </summary>
        [XmlElement("organizer_id")]
        public string OrganizerId { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页的大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询时间范围开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务模板id集合
        /// </summary>
        [XmlArray("task_template_ids")]
        [XmlArrayItem("string")]
        public List<string> TaskTemplateIds { get; set; }
    }
}
