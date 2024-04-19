using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoAgreementUnsignResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoAgreementUnsignResponse : AopResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 调用芝麻GO结算受理接口时，需要传入该值
        /// </summary>
        [XmlElement("withhold_plan_no")]
        public string WithholdPlanNo { get; set; }
    }
}
