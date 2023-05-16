using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplaintInfoQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ComplaintInfoQueryResponse : AopObject
    {
        /// <summary>
        /// 投诉单涉及交易总金额
        /// </summary>
        [XmlElement("complain_amount")]
        public string ComplainAmount { get; set; }

        /// <summary>
        /// 用户投诉内容
        /// </summary>
        [XmlElement("complain_content")]
        public string ComplainContent { get; set; }

        /// <summary>
        /// 投诉单涉及的交易信息
        /// </summary>
        [XmlArray("complaint_trade_info_list")]
        [XmlArrayItem("complaint_trade_info")]
        public List<ComplaintTradeInfo> ComplaintTradeInfoList { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 投诉时间
        /// </summary>
        [XmlElement("gmt_complain")]
        public string GmtComplain { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("gmt_overdue")]
        public string GmtOverdue { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [XmlElement("gmt_process")]
        public string GmtProcess { get; set; }

        /// <summary>
        /// 推送时间
        /// </summary>
        [XmlElement("gmt_risk_finish_time")]
        public string GmtRiskFinishTime { get; set; }

        /// <summary>
        /// 投诉主表的主键id，查询详情时使用本id进行查询
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 投诉单中被投诉方的名称
        /// </summary>
        [XmlElement("opposite_name")]
        public string OppositeName { get; set; }

        /// <summary>
        /// 被投诉人pid
        /// </summary>
        [XmlElement("opposite_pid")]
        public string OppositePid { get; set; }

        /// <summary>
        /// 商家处理投诉结果码
        /// </summary>
        [XmlElement("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 商家处理备注图片url列表
        /// </summary>
        [XmlArray("process_img_url_list")]
        [XmlArrayItem("string")]
        public List<string> ProcessImgUrlList { get; set; }

        /// <summary>
        /// 商家处理结果码对应描述，与结果码一一对应
        /// </summary>
        [XmlElement("process_message")]
        public string ProcessMessage { get; set; }

        /// <summary>
        /// 商家处理备注
        /// </summary>
        [XmlElement("process_remark")]
        public string ProcessRemark { get; set; }

        /// <summary>
        /// 投诉单状态码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 投诉单状态枚举值描述，与投诉单状态码一一对应
        /// </summary>
        [XmlElement("status_description")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// 投诉单号id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 投诉交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
