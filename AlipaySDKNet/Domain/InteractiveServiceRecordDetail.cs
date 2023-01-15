using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteractiveServiceRecordDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InteractiveServiceRecordDetail : AopObject
    {
        /// <summary>
        /// 批量任务id
        /// </summary>
        [XmlElement("batch_biz_id")]
        public string BatchBizId { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 场景名
        /// </summary>
        [XmlElement("commodity_scene")]
        public string CommodityScene { get; set; }

        /// <summary>
        /// 内容code
        /// </summary>
        [XmlElement("content_code")]
        public string ContentCode { get; set; }

        /// <summary>
        /// 对话详情
        /// </summary>
        [XmlElement("dialogue")]
        public string Dialogue { get; set; }

        /// <summary>
        /// 音视频下载链接，oss地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 终止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 交互时长，单位秒，如10秒
        /// </summary>
        [XmlElement("interact_duration")]
        public long InteractDuration { get; set; }

        /// <summary>
        /// 流程标签，代表调用或交互结果
        /// </summary>
        [XmlElement("interact_result")]
        public string InteractResult { get; set; }

        /// <summary>
        /// open id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 产品code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 风险标签
        /// </summary>
        [XmlArray("risk_labels")]
        [XmlArrayItem("string")]
        public List<string> RiskLabels { get; set; }

        /// <summary>
        /// 风险程度
        /// </summary>
        [XmlArray("risk_types")]
        [XmlArrayItem("string")]
        public List<string> RiskTypes { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交互轮数
        /// </summary>
        [XmlElement("total_round")]
        public long TotalRound { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
