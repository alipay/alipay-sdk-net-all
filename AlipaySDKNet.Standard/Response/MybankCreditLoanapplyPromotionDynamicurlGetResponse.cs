using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyPromotionDynamicurlGetResponse.
    /// </summary>
    public class MybankCreditLoanapplyPromotionDynamicurlGetResponse : AopResponse
    {
        /// <summary>
        /// 推广活动需要跳转的动态链接地址
        /// </summary>
        [XmlElement("dynamic_url")]
        public string DynamicUrl { get; set; }
    }
}
