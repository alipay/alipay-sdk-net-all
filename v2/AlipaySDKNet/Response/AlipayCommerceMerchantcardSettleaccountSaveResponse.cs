using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardSettleaccountSaveResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardSettleaccountSaveResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
