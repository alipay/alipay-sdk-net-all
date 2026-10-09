using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntfarmDonationinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntfarmDonationinfoQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
