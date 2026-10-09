using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareAuthCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFamilyShareAuthCheckModel : AopObject
    {
        /// <summary>
        /// 共享授权的资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 共享授权组件的被分享人的业务用户ID
        /// </summary>
        [XmlElement("target_biz_user_id")]
        public string TargetBizUserId { get; set; }

        /// <summary>
        /// 被分享人的业务用户id，目前支持三种账号来源，ALIPAY：支付宝用户id，HAVANA：集团集团havanaId，ARCHIVE：关系平台档案id
        /// </summary>
        [XmlElement("target_user_biz_source")]
        public string TargetUserBizSource { get; set; }

        /// <summary>
        /// 共享授权组件的分享人的支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
