using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyaggrSubinviteQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceEnergyaggrSubinviteQueryResponse : AopResponse
    {
        /// <summary>
        /// 场站子邀约中的场站基准曲线
        /// </summary>
        [XmlArray("base_line")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> BaseLine { get; set; }

        /// <summary>
        /// 申报响应
        /// </summary>
        [XmlElement("bid_result")]
        public BidResult BidResult { get; set; }

        /// <summary>
        /// 申报开始时间
        /// </summary>
        [XmlElement("declare_start_time")]
        public string DeclareStartTime { get; set; }

        /// <summary>
        /// 建议策略
        /// </summary>
        [XmlElement("declare_strategy")]
        public DeclareStrategy DeclareStrategy { get; set; }

        /// <summary>
        /// 响应评价结果
        /// </summary>
        [XmlElement("evaluate_result")]
        public EvaluateResult EvaluateResult { get; set; }

        /// <summary>
        /// 邀约ID
        /// </summary>
        [XmlElement("invite_id")]
        public string InviteId { get; set; }

        /// <summary>
        /// 能量交易邀约名称
        /// </summary>
        [XmlElement("invite_name")]
        public string InviteName { get; set; }

        /// <summary>
        /// 邀约发布时间
        /// </summary>
        [XmlElement("invite_release_time")]
        public string InviteReleaseTime { get; set; }

        /// <summary>
        /// 邀约类型
        /// </summary>
        [XmlElement("invite_type")]
        public string InviteType { get; set; }

        /// <summary>
        /// 需求响应邀约中的市场需求曲线
        /// </summary>
        [XmlArray("market_demand")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> MarketDemand { get; set; }

        /// <summary>
        /// 申报策略
        /// </summary>
        [XmlElement("response_declare")]
        public ResponseDeclare ResponseDeclare { get; set; }

        /// <summary>
        /// 响应结束时间
        /// </summary>
        [XmlElement("response_end_time")]
        public string ResponseEndTime { get; set; }

        /// <summary>
        /// 响应开始时间
        /// </summary>
        [XmlElement("response_start_time")]
        public string ResponseStartTime { get; set; }

        /// <summary>
        /// 南向申报截止时间
        /// </summary>
        [XmlElement("south_declare_end_time")]
        public string SouthDeclareEndTime { get; set; }

        /// <summary>
        /// 子邀约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子邀约ID
        /// </summary>
        [XmlElement("sub_invite_id")]
        public string SubInviteId { get; set; }
    }
}
