using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPaysharingprodFamilypayQueryResponse.
    /// </summary>
    public class AlipayPayAppPaysharingprodFamilypayQueryResponse : AopResponse
    {
        /// <summary>
        /// 指定查询卡时返回该字段
        /// </summary>
        [XmlElement("card_info")]
        public FamilyPayCardInfo CardInfo { get; set; }
    }
}
