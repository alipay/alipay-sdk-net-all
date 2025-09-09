using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionrecgDeviceoperateQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAivisionrecgDeviceoperateQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作记录结果
        /// </summary>
        [XmlArray("ret_result")]
        [XmlArrayItem("scales_activation_code_device_relation_info")]
        public List<ScalesActivationCodeDeviceRelationInfo> RetResult { get; set; }
    }
}
