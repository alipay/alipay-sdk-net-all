using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingShowwindowContentQueryResponse.
    /// </summary>
    public class AlipayMarketingShowwindowContentQueryResponse : AopResponse
    {
        /// <summary>
        /// 每个设备的节目投放状态
        /// </summary>
        [XmlArray("device_content_list")]
        [XmlArrayItem("device_content")]
        public List<DeviceContent> DeviceContentList { get; set; }
    }
}
