using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMultimediaXnnminiBizCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMultimediaXnnminiBizCreateModel : AopObject
    {
        /// <summary>
        /// 业务描述
        /// </summary>
        [XmlElement("des")]
        public string Des { get; set; }

        /// <summary>
        /// 模型绑定应用id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模型创建用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
