using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCusomterAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCusomterAccountQueryModel : AopObject
    {
        /// <summary>
        /// 符合中国区域的手机号，不需要+86
        /// </summary>
        [XmlElement("mobile_number")]
        public string MobileNumber { get; set; }
    }
}
