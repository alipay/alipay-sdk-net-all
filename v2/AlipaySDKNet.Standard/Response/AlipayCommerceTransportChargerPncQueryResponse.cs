using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerPncQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerPncQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通车辆
        /// </summary>
        [XmlArray("cars")]
        [XmlArrayItem("car_response")]
        public List<CarResponse> Cars { get; set; }

        /// <summary>
        /// 即插即充服务开通状态（true/false）
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
