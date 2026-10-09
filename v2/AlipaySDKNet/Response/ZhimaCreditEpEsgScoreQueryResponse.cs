using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEsgScoreQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEsgScoreQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// ESG评价分，1-100
        /// </summary>
        [XmlElement("esg_score")]
        public string EsgScore { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }
    }
}
