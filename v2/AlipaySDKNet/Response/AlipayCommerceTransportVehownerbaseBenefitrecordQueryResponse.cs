using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseBenefitrecordQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehownerbaseBenefitrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益流水查询组件
        /// </summary>
        [XmlElement("components")]
        public BenefitRecordQueryResponseComponents Components { get; set; }

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
