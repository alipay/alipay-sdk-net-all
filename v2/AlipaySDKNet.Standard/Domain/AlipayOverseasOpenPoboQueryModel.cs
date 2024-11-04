using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPoboQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenPoboQueryModel : AopObject
    {
        /// <summary>
        /// 代缴单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
