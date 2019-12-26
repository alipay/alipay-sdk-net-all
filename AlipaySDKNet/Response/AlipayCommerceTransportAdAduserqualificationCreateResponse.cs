using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdAduserqualificationCreateResponse : AopResponse
    {
        /// <summary>
        /// 资质id+ 用户资质id，唯一标识用户的创建的一个资质
        /// </summary>
        [XmlElement("qualification_id")]
        public long QualificationId { get; set; }
    }
}
