using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcChargeBillQueryResponse.
    /// </summary>
    public class AlipayCommerceEcChargeBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务费信息列表
        /// </summary>
        [XmlArray("service_fee_list")]
        [XmlArrayItem("service_fee_info")]
        public List<ServiceFeeInfo> ServiceFeeList { get; set; }
    }
}
