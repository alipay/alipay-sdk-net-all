using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmServiceitemQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmServiceitemQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_item_list")]
        [XmlArrayItem("service_item_info")]
        public List<ServiceItemInfo> ServiceItemList { get; set; }
    }
}
