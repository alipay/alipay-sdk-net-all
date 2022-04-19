using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSceneCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSceneCreateModel : AopObject
    {
        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 信用卡拓展场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
