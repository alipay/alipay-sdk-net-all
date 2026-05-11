using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("order_service_package_vo_list")]
        [XmlArrayItem("order_service_package_v_o")]
        public List<OrderServicePackageVO> OrderServicePackageVoList { get; set; }
    }
}
