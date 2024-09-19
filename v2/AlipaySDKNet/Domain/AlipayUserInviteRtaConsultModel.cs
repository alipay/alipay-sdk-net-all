using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserInviteRtaConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInviteRtaConsultModel : AopObject
    {
        /// <summary>
        /// 加密类型，空表示不加密
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// userId的映射字段，OpenId改造
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 设备标识信息，包括IMEI，IDFA，OAID。 注意：IMEI必须为MD5加密类型，CAID则为原文设备号_版本格式，如:99ef8a8ae8ce8d70d8e4e515bfea60b1_20230330
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 查询的设备类型（IMEI、IDFA、OAID、USERID、OPENID、CAID）
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 咨询策略组，包含一个或多个目标咨询策略的组合，由运营分配
        /// </summary>
        [XmlElement("target_crowd_package_key")]
        public string TargetCrowdPackageKey { get; set; }
    }
}
