using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierCourtassessPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierCourtassessPrecreateModel : AopObject
    {
        /// <summary>
        /// 入口来源
        /// </summary>
        [XmlElement("derived_from")]
        public string DerivedFrom { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务场景，COURT_ASSESS表示涉诉风险评估
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
