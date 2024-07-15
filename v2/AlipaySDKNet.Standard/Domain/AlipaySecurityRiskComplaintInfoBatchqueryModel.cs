using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskComplaintInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskComplaintInfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页查询页码，不传则默认为1
        /// </summary>
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 按投诉时间范围进行查询：时间范围的上界，取值单位为秒
        /// </summary>
        [XmlElement("gmt_complaint_end")]
        public string GmtComplaintEnd { get; set; }

        /// <summary>
        /// 按投诉时间范围进行查询：时间范围的下界，取值单位为秒
        /// </summary>
        [XmlElement("gmt_complaint_start")]
        public string GmtComplaintStart { get; set; }

        /// <summary>
        /// 按处理时间范围进行查询：时间范围的上界，取值单位为秒
        /// </summary>
        [XmlElement("gmt_process_end")]
        public string GmtProcessEnd { get; set; }

        /// <summary>
        /// 按处理时间范围进行查询：时间范围的下界，取值单位为秒
        /// </summary>
        [XmlElement("gmt_process_start")]
        public string GmtProcessStart { get; set; }

        /// <summary>
        /// 分页查询每次查询的数据量，不传则默认为10，取值单位为条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询条件：投诉状态列表
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 投诉单号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 查询条件：投诉单号列表
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
