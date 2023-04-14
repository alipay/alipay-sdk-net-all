using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDataDistributeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDataDistributeInfo : AopObject
    {
        /// <summary>
        /// 未分发到场景的具体原因。开发者可根据具体原因定位解决问题后发起重试。
        /// </summary>
        [XmlElement("not_distribute_reason")]
        public string NotDistributeReason { get; set; }

        /// <summary>
        /// 分发场景code。 具体枚举值如下：SERVICE_MSG-订单消息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 分发场景名，对应scene_code。
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
