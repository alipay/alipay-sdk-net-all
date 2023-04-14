using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyBkruralindustryTrackAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyBkruralindustryTrackAddModel : AopObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("business_no")]
        public string BusinessNo { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用户编号类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 代表唯一的请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 埋点数据
        /// </summary>
        [XmlElement("track_data")]
        public string TrackData { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
