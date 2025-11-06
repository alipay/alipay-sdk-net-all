using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasItemQueryResponse.
    /// </summary>
    public class AlipayCommerceGasItemQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("fuel_item_info")]
        public List<FuelItemInfo> ItemList { get; set; }
    }
}
