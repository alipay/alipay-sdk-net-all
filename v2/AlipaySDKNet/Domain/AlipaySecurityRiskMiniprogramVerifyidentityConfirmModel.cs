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
        /// 身份核验场景CODE，为接入场景的英文名称，比如登陆login, 风险校验riskVerify, 支付payment等，需保证同一商户下多种接入场景code的唯一性
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
