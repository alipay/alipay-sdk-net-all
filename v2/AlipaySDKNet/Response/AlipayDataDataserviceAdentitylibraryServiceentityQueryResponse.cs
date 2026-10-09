using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryServiceentityQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdentitylibraryServiceentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 实体详情返回结果
        /// </summary>
        [XmlElement("result")]
        public ServiceEntity Result { get; set; }
    }
}
