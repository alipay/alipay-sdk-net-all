using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeMiniappUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeMiniappUnbindModel : AopObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 需要绑定小程序的移动应用ID
        /// </summary>
        [XmlElement("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
