using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitVerifyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitVerifyCreateModel : AopObject
    {
        /// <summary>
        /// 本次动作核身的业务单号，用于后续操作的业务幂等号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 走iframe通过前端postMessage方式获取结果-无需传递该参数，如果走回跳url方式得到核身结果则必传
        /// </summary>
        [XmlElement("call_back_url")]
        public string CallBackUrl { get; set; }

        /// <summary>
        /// 账户归属人对应的支付宝账号
        /// </summary>
        [XmlElement("publisher_user_id")]
        public string PublisherUserId { get; set; }

        /// <summary>
        /// 风控参数
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 核身场景支付宝分配
        /// </summary>
        [XmlElement("verify_scene")]
        public string VerifyScene { get; set; }
    }
}
