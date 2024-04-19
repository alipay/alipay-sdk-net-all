using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrpreorderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrpreorderCancelModel : AopObject
    {
        /// <summary>
        /// 预订单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
