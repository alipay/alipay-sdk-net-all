using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBankcardCertificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBankcardCertificationQueryModel : AopObject
    {
        /// <summary>
        /// OpenId开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
