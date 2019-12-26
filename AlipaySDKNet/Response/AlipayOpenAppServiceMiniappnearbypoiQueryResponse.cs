using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbypoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务poi信息列表
        /// </summary>
        [XmlElement("addresses")]
        public AddressDTO Addresses { get; set; }
    }
}
