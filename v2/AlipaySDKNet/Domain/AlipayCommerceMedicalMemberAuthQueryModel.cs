using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMemberAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMemberAuthQueryModel : AopObject
    {
        /// <summary>
        /// 医疗会员token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
