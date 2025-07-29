using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DentalArchivesShopStaff Data Structure.
    /// </summary>
    [Serializable]
    public class DentalArchivesShopStaff : AopObject
    {
        /// <summary>
        /// 店员账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 店员角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 蚂蚁门店店员名称
        /// </summary>
        [XmlElement("staff_name")]
        public string StaffName { get; set; }

        /// <summary>
        /// 店员用户ID
        /// </summary>
        [XmlElement("staff_user_id")]
        public string StaffUserId { get; set; }
    }
}
