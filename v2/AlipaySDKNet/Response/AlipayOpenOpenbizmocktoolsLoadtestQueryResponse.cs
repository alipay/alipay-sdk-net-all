using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmocktoolsLoadtestQueryResponse.
    /// </summary>
    public class AlipayOpenOpenbizmocktoolsLoadtestQueryResponse : AopResponse
    {
        /// <summary>
        /// hello
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
