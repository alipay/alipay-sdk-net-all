using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodBehaviorlogBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodBehaviorlogBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 日志关联的设备信息
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("device_behavior_log_response")]
        public List<DeviceBehaviorLogResponse> ResultList { get; set; }
    }
}
