using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsurancePerformstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsurancePerformstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益服务明细列表
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("equity_service_info")]
        public List<EquityServiceInfo> ServiceList { get; set; }

        /// <summary>
        /// 权益使用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
