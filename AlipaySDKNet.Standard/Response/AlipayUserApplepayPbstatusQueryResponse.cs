using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserApplepayPbstatusQueryResponse.
    /// </summary>
    public class AlipayUserApplepayPbstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡状态列表
        /// </summary>
        [XmlElement("pass_status_list")]
        public OpenApiPassStatus PassStatusList { get; set; }

        /// <summary>
        /// ApplePay公用响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
