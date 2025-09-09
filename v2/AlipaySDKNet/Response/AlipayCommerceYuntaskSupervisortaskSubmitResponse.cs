using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskSupervisortaskSubmitResponse.
    /// </summary>
    public class AlipayCommerceYuntaskSupervisortaskSubmitResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
