using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SingleOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class SingleOrderVO : AopObject
    {
        /// <summary>
        /// 是否可售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 履约信息
        /// </summary>
        [XmlArray("delivery_info_list")]
        [XmlArrayItem("mpc_delivery_info")]
        public List<MpcDeliveryInfo> DeliveryInfoList { get; set; }
    }
}
