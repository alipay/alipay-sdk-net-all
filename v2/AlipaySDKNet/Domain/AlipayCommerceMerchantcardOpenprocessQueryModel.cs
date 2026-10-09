using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOpenprocessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOpenprocessQueryModel : AopObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
