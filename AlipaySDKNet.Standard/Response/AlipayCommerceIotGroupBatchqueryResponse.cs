using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotGroupBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotGroupBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分组列表
        /// </summary>
        [XmlArray("groups")]
        [XmlArrayItem("device_group")]
        public List<DeviceGroup> Groups { get; set; }

        /// <summary>
        /// 设备分组总数
        /// </summary>
        [XmlArray("total")]
        [XmlArrayItem("number")]
        public List<long> Total { get; set; }
    }
}
