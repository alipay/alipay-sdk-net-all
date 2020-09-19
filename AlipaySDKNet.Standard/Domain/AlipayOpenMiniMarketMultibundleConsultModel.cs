using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMarketMultibundleConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMarketMultibundleConsultModel : AopObject
    {
        /// <summary>
        /// 端ID
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 商户小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 场景值，用于区分营销场景，例如打车星巴克
        /// </summary>
        [XmlElement("scenes")]
        public string Scenes { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
