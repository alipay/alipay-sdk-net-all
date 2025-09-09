using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovserviceRecommendSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovserviceRecommendSyncModel : AopObject
    {
        /// <summary>
        /// 信息透出渠道，如alipay、wechat、app等等
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 上报记录
        /// </summary>
        [XmlArray("feedback_record_list")]
        [XmlArrayItem("feedback_record")]
        public List<FeedbackRecord> FeedbackRecordList { get; set; }

        /// <summary>
        /// 当其他端不支持支付宝uid时，用于标识用户的唯一标识
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构所属pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
