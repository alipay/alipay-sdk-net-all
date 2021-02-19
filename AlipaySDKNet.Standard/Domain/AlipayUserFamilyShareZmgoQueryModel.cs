using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareZmgoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFamilyShareZmgoQueryModel : AopObject
    {
        /// <summary>
        /// 默认未false。设置为true时同时查询个人版协议
        /// </summary>
        [XmlElement("enable_personal")]
        public bool EnablePersonal { get; set; }

        /// <summary>
        /// 共享关系接入场景，例如健康卡family_health
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 芝麻GO模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
