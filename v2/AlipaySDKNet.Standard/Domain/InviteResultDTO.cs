using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InviteResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InviteResultDTO : AopObject
    {
        /// <summary>
        /// （被邀请人）用户唯一标识<br> 补充说明：<br> - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// （被邀请人）账号类型，参考值如下：<br> - OUT_USER_ID：商户侧用户唯一标识<br> 补充说明： - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 审批单号，不同被邀请人之间的审批单号不同（支付宝侧生成）
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
