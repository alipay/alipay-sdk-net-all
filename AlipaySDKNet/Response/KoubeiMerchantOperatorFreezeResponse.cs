using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorFreezeResponse.
    /// </summary>
    public class KoubeiMerchantOperatorFreezeResponse : AopResponse
    {
        /// <summary>
        /// 操作结果 true:success, false: failed
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
