using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LabelFeedbackDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class LabelFeedbackDetailModel : AopObject
    {
        /// <summary>
        /// 曝光实力标内容代码列表
        /// </summary>
        [XmlArray("action_content")]
        [XmlArrayItem("string")]
        public List<string> ActionContent { get; set; }

        /// <summary>
        /// 动作统计值
        /// </summary>
        [XmlElement("action_count")]
        public string ActionCount { get; set; }

        /// <summary>
        /// 动作发生日期，建议使用YYYY-MM-DD格式
        /// </summary>
        [XmlElement("action_date")]
        public string ActionDate { get; set; }

        /// <summary>
        /// 反馈动作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 上报统计类型。accurate标识精确值，interval标识区间值
        /// </summary>
        [XmlElement("count_type")]
        public string CountType { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
