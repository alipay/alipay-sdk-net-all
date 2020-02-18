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
        /// (加密或明文的)手机号、imei或idfa等信息
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 人群mode，运营分配，映射一个人群或几个人群的组合
        /// </summary>
        [XmlElement("target_crowd_package_key")]
        public string TargetCrowdPackageKey { get; set; }
    }
}
