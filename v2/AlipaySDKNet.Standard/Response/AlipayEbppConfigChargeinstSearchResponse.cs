using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppConfigChargeinstSearchResponse.
    /// </summary>
    public class AlipayEbppConfigChargeinstSearchResponse : AopResponse
    {
        /// <summary>
        /// 接口输出参数列表 ChargeInstResult{ List<ChargeInstMode>}对象
        /// </summary>
        [XmlArray("charge_inst_mode_result")]
        [XmlArrayItem("charge_inst_mode")]
        public List<ChargeInstMode> ChargeInstModeResult { get; set; }
    }
}
