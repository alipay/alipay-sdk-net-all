using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpPasyncQueryResponse.
    /// </summary>
    public class ZhimaCreditEpPasyncQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付收单数据集
        /// </summary>
        [XmlElement("data")]
        public PayFlowModel Data { get; set; }
    }
}
