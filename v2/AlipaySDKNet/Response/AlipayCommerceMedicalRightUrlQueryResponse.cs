using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRightUrlQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalRightUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务详情链接信息
        /// </summary>
        [XmlElement("right_detail_url_info")]
        public RightDetailUrlInfo RightDetailUrlInfo { get; set; }
    }
}
