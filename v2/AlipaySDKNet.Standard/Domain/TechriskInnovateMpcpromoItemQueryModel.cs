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
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页展示时，每页展示的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

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
