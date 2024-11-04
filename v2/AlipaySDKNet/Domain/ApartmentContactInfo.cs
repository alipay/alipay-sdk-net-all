using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApartmentContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApartmentContactInfo : AopObject
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人的头像地址
        /// </summary>
        [XmlElement("contact_profile_pic")]
        public string ContactProfilePic { get; set; }

        /// <summary>
        /// 商家IM支付宝端内的跳转链接
        /// </summary>
        [XmlElement("im_url")]
        public string ImUrl { get; set; }

        /// <summary>
        /// 联系人的电话号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
