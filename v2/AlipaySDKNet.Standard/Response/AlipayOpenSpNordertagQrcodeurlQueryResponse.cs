using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordertagQrcodeurlQueryResponse.
    /// </summary>
    public class AlipayOpenSpNordertagQrcodeurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 物料信息返回值
        /// </summary>
        [XmlElement("tag_info")]
        public NOrderTagQueryByCoilNoResp TagInfo { get; set; }
    }
}
