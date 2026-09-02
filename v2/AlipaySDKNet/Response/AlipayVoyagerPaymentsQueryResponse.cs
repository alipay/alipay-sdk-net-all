using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerPaymentsQueryResponse.
    /// </summary>
    public class AlipayVoyagerPaymentsQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付订单
        /// </summary>
        [XmlElement("pay_order")]
        public StandardPayOrderDTO PayOrder { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
