using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarVehicleCertifiedQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehicleCertifiedQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证结果列表
        /// </summary>
        [XmlArray("cert_list")]
        [XmlArrayItem("plate_no_cert_dto")]
        public List<PlateNoCertDto> CertList { get; set; }
    }
}
