using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IpRoleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IpRoleInfoDTO : AopObject
    {
        /// <summary>
        /// gmt_create 不唯一 代表创建时间 无枚举 被调用方提供 无特殊说明
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// ip_role_id 唯一 代表操作员唯一ID 无枚举 被调方提供 无特殊说明
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// job 不唯一 代表用户岗位 无枚举 被调用方提供 无特殊说明
        /// </summary>
        [XmlElement("job")]
        public string Job { get; set; }

        /// <summary>
        /// phone 唯一 代表用户手机号 无枚举 被调用方提供 无特殊说明
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// real_name 真实姓名 不唯一 用于代表用户真实姓名  无枚举 被调方提供 无特殊说明
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// reg_from 不唯一 代表注册来源  ALIPAY 被调方提供 无特殊说明
        /// </summary>
        [XmlElement("reg_from")]
        public string RegFrom { get; set; }

        /// <summary>
        /// remark 不唯一 用于存储其他拓展信息  无枚举  被调方提供 无特殊说明
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// work_no 唯一 代表用户工号 无枚举 被调用方提供 无特殊说明
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
