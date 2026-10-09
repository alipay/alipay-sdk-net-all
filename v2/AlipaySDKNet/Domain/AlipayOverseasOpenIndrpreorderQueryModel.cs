using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrpreorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrpreorderQueryModel : AopObject
    {
        /// <summary>
        /// 订单号
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
