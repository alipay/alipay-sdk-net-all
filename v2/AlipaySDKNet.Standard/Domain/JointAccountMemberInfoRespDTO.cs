using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountMemberInfoRespDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountMemberInfoRespDTO : AopObject
    {
        /// <summary>
        /// （群成员）支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 成员角色：<br> -MASTER：创建人<br> -ADMIN：管理员<br> -MEMBER：群成员<br>
        /// </summary>
        [XmlElement("operate_role")]
        public string OperateRole { get; set; }

        /// <summary>
        /// （群成员）支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
