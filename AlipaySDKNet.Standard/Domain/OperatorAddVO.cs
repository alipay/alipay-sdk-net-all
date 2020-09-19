using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorAddVO Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorAddVO : AopObject
    {
        /// <summary>
        /// 企业版操作员业务类型。其它类型操作员无需填写
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作员联系方式列表
        /// </summary>
        [XmlArray("contacts")]
        [XmlArrayItem("operator_contact_v_o")]
        public List<OperatorContactVO> Contacts { get; set; }

        /// <summary>
        /// 操作员登录号。如果不需要注册登录号则无需填写。 该登录号与已有支付宝账号登录号不可以重复。
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 操作员登录号类型。如果不需要注册登录号则无需填写。 枚举值参考LogonIdTypeEnum 范围如下： 1=手机号 2=Email 3=企业操作员昵称方式
        /// </summary>
        [XmlElement("logon_id_type")]
        public string LogonIdType { get; set; }

        /// <summary>
        /// 操作员登录密码（密文）。如果不需要注册登录号则不需要填写。
        /// </summary>
        [XmlElement("logon_password")]
        public string LogonPassword { get; set; }

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
        /// 操作员名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作员昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
