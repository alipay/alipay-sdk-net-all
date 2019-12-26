using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechConsultResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechConsultResponse : AopResponse
    {
        /// <summary>
        /// 收费项计价结果列表（List<POJO>的JSON对象） POJO中包含feeItemCode收费项编码、eventCode事件码、price计价结果金额、highPrecisionPrice高精度计价结果金额、currency币种、settleType结算类型。
        /// </summary>
        [XmlElement("consult_details")]
        public string ConsultDetails { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
