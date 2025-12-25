using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseRegistercarApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseRegistercarApplyResponse : AopResponse
    {
        /// <summary>
        /// 未备案成功车辆列表
        /// </summary>
        [XmlElement("car_infos")]
        public FailCarInfos CarInfos { get; set; }
    }
}
