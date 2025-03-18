using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateDevicebindQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备绑定申请单列表
        /// </summary>
        [XmlArray("apply_result_info")]
        [XmlArrayItem("bind_apply_result")]
        public List<BindApplyResult> ApplyResultInfo { get; set; }

        /// <summary>
        /// 设备当前绑定信息
        /// </summary>
        [XmlElement("bind_info")]
        public IotDeviceBindBaseInfo BindInfo { get; set; }
    }
}
