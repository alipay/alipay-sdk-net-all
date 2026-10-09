using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataInfoMobilecityQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInfoMobilecityQueryResponse : AopResponse
    {
        /// <summary>
        /// 手机归属地对象,三个field均为string类型,手机号前七,phoneNumber; ,省份province;,城市city;
        /// </summary>
        [XmlElement("mobile_city")]
        public SecuritydataMobileCity MobileCity { get; set; }
    }
}
