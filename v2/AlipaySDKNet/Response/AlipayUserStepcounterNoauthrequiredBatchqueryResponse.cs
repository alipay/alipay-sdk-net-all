using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserStepcounterNoauthrequiredBatchqueryResponse.
    /// </summary>
    public class AlipayUserStepcounterNoauthrequiredBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的用户日计步信息
        /// </summary>
        [XmlArray("step_info")]
        [XmlArrayItem("stepcounter_data_info")]
        public List<StepcounterDataInfo> StepInfo { get; set; }
    }
}
