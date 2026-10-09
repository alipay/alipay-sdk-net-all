using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanDataSaveResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkloanDataSaveResponse : AopResponse
    {
        /// <summary>
        /// 商户单号，正常调用返回的数据和入参中的商户单号保持一致
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }
    }
}
