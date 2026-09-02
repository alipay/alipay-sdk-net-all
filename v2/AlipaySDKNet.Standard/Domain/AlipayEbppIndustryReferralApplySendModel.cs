using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryReferralApplySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryReferralApplySendModel : AopObject
    {
        /// <summary>
        /// 候选人姓名
        /// </summary>
        [XmlElement("candidate_name")]
        public string CandidateName { get; set; }

        /// <summary>
        /// 候选人手机号
        /// </summary>
        [XmlElement("candidate_phone")]
        public string CandidatePhone { get; set; }

        /// <summary>
        /// 城市编码，精确到区县六位匹配
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 岗位ID
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 合作方唯一请求号，用来做幂等。新接入的合作方必选，已接入过的合作方可选
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推荐官ID
        /// </summary>
        [XmlElement("recommender_id")]
        public string RecommenderId { get; set; }

        /// <summary>
        /// 测试订单标识。不传默认是false，表示非测试订单
        /// </summary>
        [XmlElement("test_order")]
        public bool TestOrder { get; set; }
    }
}
