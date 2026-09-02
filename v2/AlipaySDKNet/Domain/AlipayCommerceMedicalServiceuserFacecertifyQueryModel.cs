using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserFacecertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceuserFacecertifyQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 外部用户类型
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 有效期（秒）
        /// </summary>
        [XmlElement("valid_seconds")]
        public string ValidSeconds { get; set; }
    }
}
