using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditProductSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditProductSignModel : AopObject
    {
        /// <summary>
        /// 扩展值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 生效模型策略
        /// </summary>
        [XmlElement("valid_strategy")]
        public OpenApiValidStrategy ValidStrategy { get; set; }
    }
}
