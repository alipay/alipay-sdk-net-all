using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerPaymentsCancelResponse.
    /// </summary>
    public class AlipayVoyagerPaymentsCancelResponse : AopResponse
    {
        /// <summary>
        /// 必填
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
