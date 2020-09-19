using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelBenefitChangeNotifyResponse.
    /// </summary>
    public class AlipayOverseasTravelBenefitChangeNotifyResponse : AopResponse
    {
        /// <summary>
        /// 收单站在gn的id
        /// </summary>
        [XmlElement("acquirer_id")]
        public string AcquirerId { get; set; }

        /// <summary>
        /// 发卡站在gn的id
        /// </summary>
        [XmlElement("psp_id")]
        public string PspId { get; set; }

        /// <summary>
        /// 通知结果
        /// </summary>
        [XmlElement("result")]
        public Result Result { get; set; }
    }
}
