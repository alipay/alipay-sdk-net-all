using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducatePlaceDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducatePlaceDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 位置信息
        /// </summary>
        [XmlElement("place_info")]
        public EduPlaceInfo PlaceInfo { get; set; }
    }
}
