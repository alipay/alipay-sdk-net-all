using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestProjectQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestProjectQueryResponse : AopResponse
    {
        /// <summary>
        /// 请联系接口开发人员咨询相关参数
        /// </summary>
        [XmlArray("projects")]
        [XmlArrayItem("string")]
        public List<string> Projects { get; set; }
    }
}
