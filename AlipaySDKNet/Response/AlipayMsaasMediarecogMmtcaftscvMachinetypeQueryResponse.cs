using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 视觉货柜机型信息列表
        /// </summary>
        [XmlArray("machine_types")]
        [XmlArrayItem("machine_type")]
        public List<MachineType> MachineTypes { get; set; }
    }
}
