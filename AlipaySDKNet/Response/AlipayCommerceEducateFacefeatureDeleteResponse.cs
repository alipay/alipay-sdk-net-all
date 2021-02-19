using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureDeleteResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureDeleteResponse : AopResponse
    {
        /// <summary>
        /// 出库失败的faceId集合。
        /// </summary>
        [XmlArray("face_ids")]
        [XmlArrayItem("string")]
        public List<string> FaceIds { get; set; }
    }
}
