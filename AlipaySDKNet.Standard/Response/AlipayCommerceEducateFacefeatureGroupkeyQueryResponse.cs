using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureGroupkeyQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureGroupkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 人脸库key
        /// </summary>
        [XmlElement("group_key")]
        public string GroupKey { get; set; }
    }
}
