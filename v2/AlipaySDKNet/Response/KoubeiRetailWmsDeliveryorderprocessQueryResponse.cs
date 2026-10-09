using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsDeliveryorderprocessQueryResponse : AopResponse
    {
        /// <summary>
        /// 物流单据状态列表
        /// </summary>
        [XmlArray("delivery_order_process_vo_list")]
        [XmlArrayItem("delivery_order_process_v_o")]
        public List<DeliveryOrderProcessVO> DeliveryOrderProcessVoList { get; set; }
    }
}
