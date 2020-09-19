using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备列表
        /// </summary>
        [XmlArray("device_list")]
        [XmlArrayItem("ampe_device_v_o")]
        public List<AmpeDeviceVO> DeviceList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
