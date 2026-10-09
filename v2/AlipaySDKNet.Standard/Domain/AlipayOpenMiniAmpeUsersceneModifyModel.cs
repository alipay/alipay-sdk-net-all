using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeUsersceneModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeUsersceneModifyModel : AopObject
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 用户不支持的场景列表
        /// </summary>
        [XmlArray("disable_scene_id_list")]
        [XmlArrayItem("number")]
        public List<long> DisableSceneIdList { get; set; }

        /// <summary>
        /// 用户选择的场景id列表
        /// </summary>
        [XmlArray("enable_scene_id_list")]
        [XmlArrayItem("number")]
        public List<long> EnableSceneIdList { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 通过ampe获取的用户标识
        /// </summary>
        [XmlElement("user_key")]
        public string UserKey { get; set; }
    }
}
