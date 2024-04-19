using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CmtContentBackFlow Data Structure.
    /// </summary>
    [Serializable]
    public class CmtContentBackFlow : AopObject
    {
        /// <summary>
        /// 订单的评价状态 ,此处只返回评价的基础状态
        /// </summary>
        [XmlElement("cmt_status")]
        public string CmtStatus { get; set; }

        /// <summary>
        /// 订单主观评价内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 内容评价图片链接列表
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("string")]
        public List<string> Pictures { get; set; }

        /// <summary>
        /// 若拉取兜底模版则无子维度评价明细列表
        /// </summary>
        [XmlArray("score_details")]
        [XmlArrayItem("score_detail_info")]
        public List<ScoreDetailInfo> ScoreDetails { get; set; }

        /// <summary>
        /// 评级总分
        /// </summary>
        [XmlElement("total_score")]
        public long TotalScore { get; set; }

        /// <summary>
        /// 评价总分对应用户选择标签
        /// </summary>
        [XmlArray("total_score_label")]
        [XmlArrayItem("string")]
        public List<string> TotalScoreLabel { get; set; }
    }
}
