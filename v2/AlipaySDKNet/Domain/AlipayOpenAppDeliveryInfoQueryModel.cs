using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppDeliveryInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeliveryInfoQueryModel : AopObject
    {
        /// <summary>
        /// 查询的履约ID列表，与履约类型不能同时为空。建议接入方在履约同步时持久化存储履约ID信息，最大支持上限500
        /// </summary>
        [XmlArray("delivery_ids")]
        [XmlArrayItem("string")]
        public List<string> DeliveryIds { get; set; }

        /// <summary>
        /// 该入参需要和履约信息ID列表不能同时为空，会查询对应appId下的该种履约类型的履约信息，最大查询数量500条
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }
    }
}
