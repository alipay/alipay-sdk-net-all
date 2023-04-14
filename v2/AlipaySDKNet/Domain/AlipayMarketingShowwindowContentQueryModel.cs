using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingShowwindowContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingShowwindowContentQueryModel : AopObject
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        [XmlArray("device_info_list")]
        [XmlArrayItem("iot_query_device_info")]
        public List<IotQueryDeviceInfo> DeviceInfoList { get; set; }

        /// <summary>
        /// 时间 YYYYMMDD（20210801）
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 接口请求源，如商米为SM
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
