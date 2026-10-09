using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallDivisionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallDivisionQueryResponse : AopResponse
    {
        /// <summary>
        /// 父地区码的所有子地区列表
        /// </summary>
        [XmlArray("division_list")]
        [XmlArrayItem("lm_division_v_o")]
        public List<LmDivisionVO> DivisionList { get; set; }
    }
}
