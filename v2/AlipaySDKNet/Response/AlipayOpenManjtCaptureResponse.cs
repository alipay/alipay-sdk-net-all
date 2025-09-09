using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenManjtCaptureResponse.
    /// </summary>
    public class AlipayOpenManjtCaptureResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("response_obj")]
        public ResponseObjManjiangTest ResponseObj { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("test_plain_field")]
        [XmlArrayItem("number")]
        public List<long> TestPlainField { get; set; }
    }
}
