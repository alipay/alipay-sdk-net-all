using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsmartpayPaymentinstructionQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsmartpayPaymentinstructionQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询付款进度通用结果模型
        /// </summary>
        [XmlElement("result_set")]
        public ResponseModelForPaymentInstruction ResultSet { get; set; }
    }
}
