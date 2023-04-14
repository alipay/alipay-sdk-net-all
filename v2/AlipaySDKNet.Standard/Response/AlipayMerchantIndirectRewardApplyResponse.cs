using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectRewardApplyResponse.
    /// </summary>
    public class AlipayMerchantIndirectRewardApplyResponse : AopResponse
    {
        /// <summary>
        /// 权益发放状态。领奖审批结果，平台会对提交信息进行校验，并返回判断结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 权益编码
        /// </summary>
        [XmlElement("reward_code")]
        public string RewardCode { get; set; }
    }
}
