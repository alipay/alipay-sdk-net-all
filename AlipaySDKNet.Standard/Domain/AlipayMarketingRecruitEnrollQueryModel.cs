using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitEnrollQueryModel : AopObject
    {
        /// <summary>
        /// 报名ID，此参数和out_biz_no至少传一个，优先取enroll_id
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
