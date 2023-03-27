using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoItemQueryModel : AopObject
    {
        /// <summary>
        /// 当前appid下的推荐场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 商户定义的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
