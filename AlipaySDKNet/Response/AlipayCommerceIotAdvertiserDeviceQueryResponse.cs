using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 获取商户下设备列表
        /// </summary>
        [XmlArray("device_sn_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
