using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmFunctionQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmFunctionQueryResponse : AopResponse
    {
        /// <summary>
        /// 功能点列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function")]
        public List<Function> Functions { get; set; }
    }
}
