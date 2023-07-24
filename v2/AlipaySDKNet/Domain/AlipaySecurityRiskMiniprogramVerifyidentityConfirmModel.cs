using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskMiniprogramVerifyidentityConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskMiniprogramVerifyidentityConfirmModel : AopObject
    {
        /// <summary>
        /// 接入业务方业务唯一性id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 身份核验场景CODE，与初始化时传入一致，如login, riskVerify, payment, changePassword.
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 核身校验token，是一次核身校验服务中唯一性的token
        /// </summary>
        [XmlElement("verify_token")]
        public string VerifyToken { get; set; }
    }
}
