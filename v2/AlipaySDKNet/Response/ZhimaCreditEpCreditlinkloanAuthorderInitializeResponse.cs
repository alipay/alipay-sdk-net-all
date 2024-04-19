using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanAuthorderInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkloanAuthorderInitializeResponse : AopResponse
    {
        /// <summary>
        /// 商户单号，请与授权申请时的单号保持一致
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }
    }
}
