using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelIntlBizareaSyncResponse.
    /// </summary>
    public class AlipayOverseasTravelIntlBizareaSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }

        /// <summary>
        /// Result code
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// Result message
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
