using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserDTO : AopObject
    {
        /// <summary>
        /// 用户雇佣编号
        /// </summary>
        [XmlElement("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 域账号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名,有花名时返回花名,没有则返回真名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户工号
        /// </summary>
        [XmlElement("user_no")]
        public string UserNo { get; set; }
    }
}
