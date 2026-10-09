using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotServicemodelServicelistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotServicemodelServicelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备服务列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("device_service_v_o")]
        public List<DeviceServiceVO> List { get; set; }
    }
}
