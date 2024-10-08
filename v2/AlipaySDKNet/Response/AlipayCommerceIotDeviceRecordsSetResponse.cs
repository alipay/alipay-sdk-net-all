using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceRecordsSetResponse : AopResponse
    {
        /// <summary>
        /// 设备档案
        /// </summary>
        [XmlElement("device_records")]
        public DeviceRecords DeviceRecords { get; set; }

        /// <summary>
        /// 对设备绑定请求进行处理后的一些提示信息
        /// </summary>
        [XmlElement("device_remark")]
        public string DeviceRemark { get; set; }
    }
}
