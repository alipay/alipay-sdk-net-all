using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingFeedbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingFeedbackModel : AopObject
    {
        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 环境信息
        /// </summary>
        [XmlElement("env_info")]
        public VoyagerEnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 请求端的最后点击的埋点信息
        /// </summary>
        [XmlElement("last_spm")]
        public string LastSpm { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("voyager_feedback_record")]
        public List<VoyagerFeedbackRecord> RecordList { get; set; }

        /// <summary>
        /// 请求端源埋点信息
        /// </summary>
        [XmlElement("src_spm")]
        public string SrcSpm { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
