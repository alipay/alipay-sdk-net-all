using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryInternetbarDevicedataQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryInternetbarDevicedataQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("device_activity_data")]
        [XmlArrayItem("internetbar_device_activity_data")]
        public List<InternetbarDeviceActivityData> DeviceActivityData { get; set; }

        /// <summary>
        /// 总数据量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
