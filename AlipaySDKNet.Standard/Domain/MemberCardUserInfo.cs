using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardUserInfo : AopObject
    {
        /// <summary>
        /// 生日，格式"yyyy/MM/dd"，如果没有获得用户授权，则返回"用户未授权"
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 性别。枚举值如下：男/女。如果没有获得用户授权，则返回"用户未授权"
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 手机号，如果没有获得用户授权，则返回"用户未授权"
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名，如果没有获得用户授权，则返回"用户未授权"
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 安心充会员的开通时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
