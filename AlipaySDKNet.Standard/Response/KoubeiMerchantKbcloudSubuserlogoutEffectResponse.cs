using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserlogoutEffectResponse : AopResponse
    {
        /// <summary>
        /// 是否登出成功
        /// </summary>
        [XmlElement("flag")]
        public bool Flag { get; set; }
    }
}
