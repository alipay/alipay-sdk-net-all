using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityTestmysqltoobQueryResponse.
    /// </summary>
    public class AlipaySecurityTestmysqltoobQueryResponse : AopResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlArray("test_02")]
        [XmlArrayItem("string")]
        public List<string> Test02 { get; set; }
    }
}
