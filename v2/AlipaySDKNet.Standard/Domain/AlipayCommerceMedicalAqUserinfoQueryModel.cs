using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqUserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 用户当前2088
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户当前2088
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
