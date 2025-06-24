using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentFundAuthFreezeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentFundAuthFreezeInfoDTO : AopObject
    {
        /// <summary>
        /// 预授权成功消息通知地址，商户可通过指定该地址监听支付宝侧预授权消息
        /// </summary>
        [XmlElement("freeze_notify_url")]
        public string FreezeNotifyUrl { get; set; }

        /// <summary>
        /// 收款账户的支付宝用户号。 以2088开头的16位纯数字，如果传入则会校验该账号是否具备当前商户收款权限
        /// </summary>
        [XmlElement("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 免押风控评估金额，即租押分离能力的押金评估金额。单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("risk_assessment_price")]
        public string RiskAssessmentPrice { get; set; }
    }
}
