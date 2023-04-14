using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorQuery Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorQuery : AopObject
    {
        /// <summary>
        /// 查询操作员的唯一ID。类型由id_type决定
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// id参数的类型。取值如下： OPERATOR_ID=id填操作员ID USER_ID=id填支付宝登录userId LOGON_ID=id填操作员的登录号
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 操作员登录号类型。id_type为LOGON_ID时必填。 枚举值参考LogonIdTypeEnum 范围如下：  1=手机号 2=Email 3=企业操作员昵称方式
        /// </summary>
        [XmlElement("logon_id_type")]
        public string LogonIdType { get; set; }

        /// <summary>
        /// 操作员所属主账号ID，ID类型由main_ip_role_type定义
        /// </summary>
        [XmlElement("main_ip_role_id")]
        public string MainIpRoleId { get; set; }

        /// <summary>
        /// 操作员所属主账号类型，枚举值参考RelIpRoleTypeEnum，取值范围： 1=支付宝商户客户customerId 2=支付宝商户PID 6=支付宝开放账号OID 7=蚂蚁通行证虚拟账号ID
        /// </summary>
        [XmlElement("main_ip_role_type")]
        public string MainIpRoleType { get; set; }

        /// <summary>
        /// 查询操作员的OPENID。类型由id_type决定，当id_type为 OPEN_ID 时，使用 open_id 的值。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
