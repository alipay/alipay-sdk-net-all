using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionrecgDeviceactivationQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAivisionrecgDeviceactivationQueryResponse : AopResponse
    {
        /// <summary>
        /// 激活状态结果
        /// </summary>
        [XmlArray("ret_result")]
        [XmlArrayItem("scales_activation_code_device_info")]
        public List<ScalesActivationCodeDeviceInfo> RetResult { get; set; }
    }
}
