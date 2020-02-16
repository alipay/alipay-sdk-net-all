using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoBenefitUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoBenefitUseModel : AopObject
    {
        /// <summary>
        /// 支付宝定义的权益编码
        /// </summary>
        [XmlElement("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// ISV本次使用记录的业务单号，幂等字段
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 权益使用详情
        /// </summary>
        [XmlElement("use_detail")]
        public UseDetail UseDetail { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
