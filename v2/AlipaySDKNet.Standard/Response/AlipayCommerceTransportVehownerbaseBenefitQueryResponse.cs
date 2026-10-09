using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseBenefitQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehownerbaseBenefitQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益召回组件集
        /// </summary>
        [XmlElement("components")]
        public BenefitQueryResponseComponents Components { get; set; }

        /// <summary>
        /// 当前日期
        /// </summary>
        [XmlElement("current_date")]
        public string CurrentDate { get; set; }

        /// <summary>
        /// 方案标识
        /// </summary>
        [XmlElement("operation_param_identify")]
        public string OperationParamIdentify { get; set; }
    }
}
