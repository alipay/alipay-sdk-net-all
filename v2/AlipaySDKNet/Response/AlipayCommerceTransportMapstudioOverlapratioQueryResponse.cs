using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportMapstudioOverlapratioQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportMapstudioOverlapratioQueryResponse : AopResponse
    {
        /// <summary>
        /// 线路重复度返回值
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("line_repetition_v_o")]
        public List<LineRepetitionVO> Result { get; set; }
    }
}
