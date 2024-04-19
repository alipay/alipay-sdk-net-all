using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRecruitEnrollCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建活动报名请求是否被受理。 使用说明： a. 当该字段值是false时，说明本次创建活动报名接口调用经业务校验失败，enroll_id 会为null，但 error_info.error_message 不为空，会给出业务校验失败的具体原因； b. 当该字段值是true时，说明本次创建活动报名接口调用成功，error_info 会为null，但 enroll_id 不为空，请保存enroll_id；
        /// </summary>
        [XmlElement("accepted")]
        public bool Accepted { get; set; }

        /// <summary>
        /// 活动报名ID。创建活动报名被受理时（accepted=true）不为null。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 创建活动报名失败信息。创建活动报名未被受理时（accepted=false）不为null。
        /// </summary>
        [XmlElement("failure_info")]
        public RecruitFailureInfo FailureInfo { get; set; }

        /// <summary>
        /// 幂等ID。 由商家/ISV 自定义，创建报名时传入的 out_biz_no。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
