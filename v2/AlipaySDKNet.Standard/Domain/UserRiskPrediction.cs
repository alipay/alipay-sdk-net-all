using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserRiskPrediction Data Structure.
    /// </summary>
    [Serializable]
    public class UserRiskPrediction : AopObject
    {
        /// <summary>
        /// 用户绑定手机号被二次放号风险等级。 NO_RESULT：手机号风险未入库 NO_RISK：用户绑定手机无二次放号风险，高置信度 LOW_RISK：用户绑定手机二次放号风险较小，商户自行决策是否相信。 HIGH_RISK：用户绑定手机已被放号，高置信度
        /// </summary>
        [XmlElement("phone_recycle_risk_leve")]
        public string PhoneRecycleRiskLeve { get; set; }

        /// <summary>
        /// 用户拒付风险等级。 NO_SIGN：商户未签约。 NO_RESULT：未查询到账户信息。 LOW_RISK：用户拒付风险为低；处理建议：用户可以先享受服务，再进行支付。 MEDIUM_RISK：用户拒付风险为中；处理建议：根据业务场景客户自行判断提供或者不提供。 HIGH_RISK：用户拒付风险为高；处理建议：不建议先提供给用户服务。
        /// </summary>
        [XmlElement("refused_payment_risk_level")]
        public string RefusedPaymentRiskLevel { get; set; }
    }
}
