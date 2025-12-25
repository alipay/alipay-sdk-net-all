using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseRegistercarQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseRegistercarQueryResponse : AopResponse
    {
        /// <summary>
        /// 备案车辆列表
        /// </summary>
        [XmlElement("car_infos")]
        public CarinfosQuery CarInfos { get; set; }
    }
}
