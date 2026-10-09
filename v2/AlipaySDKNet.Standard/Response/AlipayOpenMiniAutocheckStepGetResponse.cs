using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAutocheckStepGetResponse.
    /// </summary>
    public class AlipayOpenMiniAutocheckStepGetResponse : AopResponse
    {
        /// <summary>
        /// 百格脚本步骤信息
        /// </summary>
        [XmlArray("slm_service_atomic_info")]
        [XmlArrayItem("slm_service_atomic_info_v_o")]
        public List<SlmServiceAtomicInfoVO> SlmServiceAtomicInfo { get; set; }
    }
}
