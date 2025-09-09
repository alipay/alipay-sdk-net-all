using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvatarMultiPageConfig Data Structure.
    /// </summary>
    [Serializable]
    public class AvatarMultiPageConfig : AopObject
    {
        /// <summary>
        /// 播报内容
        /// </summary>
        [XmlElement("ori_text")]
        public string OriText { get; set; }

        /// <summary>
        /// 地图图片的url信息 业务方调用天地图的静态地图接口拿到的url信息
        /// </summary>
        [XmlElement("picture_url")]
        public string PictureUrl { get; set; }
    }
}
