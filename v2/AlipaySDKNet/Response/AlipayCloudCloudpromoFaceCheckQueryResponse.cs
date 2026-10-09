using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoFaceCheckQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoFaceCheckQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
