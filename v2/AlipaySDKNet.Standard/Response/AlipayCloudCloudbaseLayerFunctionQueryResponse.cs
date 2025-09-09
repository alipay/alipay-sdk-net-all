using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerFunctionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerFunctionQueryResponse : AopResponse
    {
        /// <summary>
        /// 函数列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function_info")]
        public List<FunctionInfo> Functions { get; set; }
    }
}
