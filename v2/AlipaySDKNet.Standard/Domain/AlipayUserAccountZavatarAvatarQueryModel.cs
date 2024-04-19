using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountZavatarAvatarQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountZavatarAvatarQueryModel : AopObject
    {
        /// <summary>
        /// 数字人形象的版本参数
        /// </summary>
        [XmlElement("avatar_app_version")]
        public string AvatarAppVersion { get; set; }

        /// <summary>
        /// 设备等级
        /// </summary>
        [XmlElement("device_level")]
        public string DeviceLevel { get; set; }

        /// <summary>
        /// json扩展信息
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 场景节点，联系数字人平台分配
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 调用方的场景信息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
