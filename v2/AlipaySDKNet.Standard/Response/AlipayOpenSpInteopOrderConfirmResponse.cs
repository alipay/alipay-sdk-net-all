using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopOrderConfirmResponse.
    /// </summary>
    public class AlipayOpenSpInteopOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 一体化作业的校验结果
        /// </summary>
        [XmlArray("check_result")]
        [XmlArrayItem("integrated_open_check_info_v_o")]
        public List<IntegratedOpenCheckInfoVO> CheckResult { get; set; }
    }
}
