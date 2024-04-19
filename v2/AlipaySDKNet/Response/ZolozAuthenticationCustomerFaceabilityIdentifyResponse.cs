using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceabilityIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 能力接口返回值
        /// </summary>
        [XmlElement("biz_info")]
        public FaceAbilityExtInfo BizInfo { get; set; }
    }
}
