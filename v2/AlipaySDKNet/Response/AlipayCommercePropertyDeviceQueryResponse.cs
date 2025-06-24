using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyDeviceQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyDeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("property_device_info")]
        public List<PropertyDeviceInfo> List { get; set; }

        /// <summary>
        /// 查询到的总数量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
