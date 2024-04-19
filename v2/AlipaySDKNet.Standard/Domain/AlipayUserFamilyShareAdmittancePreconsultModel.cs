using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareAdmittancePreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFamilyShareAdmittancePreconsultModel : AopObject
    {
        /// <summary>
        /// 共享资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 标识共享业务接入我的家场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
