using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityMiniappConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskVerifyidentityMiniappConfirmModel : AopObject
    {
        /// <summary>
        /// 业务的业务流水号，例如订单id
        /// </summary>
        [XmlElement("challenge")]
        public string Challenge { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，验证时会与做身份认证时候会话中的openid做比对，如不相符核验结果不通过
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，验证时会与做身份认证时候会话中的userId做比对，如不相符核验结果不通过
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 核身校验id，是一次核身校验服务中唯一性的id
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
