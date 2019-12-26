using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataTextdifferenceBaiQueryResponse.
    /// </summary>
    public class AlipayDataIotdataTextdifferenceBaiQueryResponse : AopResponse
    {
        /// <summary>
        /// 差异化结果以json字符串呈现。
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("text_diff")]
        public List<TextDiff> Data { get; set; }
    }
}
