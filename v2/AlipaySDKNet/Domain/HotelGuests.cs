using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelGuests Data Structure.
    /// </summary>
    [Serializable]
    public class HotelGuests : AopObject
    {
        /// <summary>
        /// 入住人姓名
        /// </summary>
        [XmlElement("guest_name")]
        public string GuestName { get; set; }

        /// <summary>
        /// 入住人会员等级
        /// </summary>
        [XmlElement("member_level")]
        public string MemberLevel { get; set; }

        /// <summary>
        /// 入住人联系方式
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
