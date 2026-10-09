using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrreferralCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrreferralCreateModel : AopObject
    {
        /// <summary>
        /// 该字段填入本次推荐码生成请求的指定参数（例如指定跳转商户等）
        /// </summary>
        [XmlElement("referral_params")]
        public IndrReferralCodeRequestParamDTO ReferralParams { get; set; }

        /// <summary>
        /// 行业缴费业务场景，目前支持TUITION（留学缴费）、HOUSE_RENTAL（留学租房）
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
