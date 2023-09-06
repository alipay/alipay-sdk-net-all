using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountAvatarPictureCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountAvatarPictureCreateModel : AopObject
    {
        /// <summary>
        /// json扩展信息
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 调用场景节点信息
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 调用场景信息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 合照模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
