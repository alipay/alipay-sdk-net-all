using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneAgreementUseResponse.
    /// </summary>
    public class ZhimaCreditEpSceneAgreementUseResponse : AopResponse
    {
        /// <summary>
        /// 信用订单号
        /// </summary>
        [XmlElement("credit_order_no")]
        public string CreditOrderNo { get; set; }
    }
}
