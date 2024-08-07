using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIdeployShiftQueryResponse.
    /// </summary>
    public class AlipayIserviceIdeployShiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 班次信息
        /// </summary>
        [XmlArray("shift_list")]
        [XmlArrayItem("shift_base_info")]
        public List<ShiftBaseInfo> ShiftList { get; set; }
    }
}
