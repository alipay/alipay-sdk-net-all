using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPaysharingprodFamilypayModifyResponse.
    /// </summary>
    public class AlipayPayAppPaysharingprodFamilypayModifyResponse : AopResponse
    {
        /// <summary>
        /// 亲情卡信息
        /// </summary>
        [XmlElement("card_info")]
        public FamilyPayCardInfo CardInfo { get; set; }
    }
}
