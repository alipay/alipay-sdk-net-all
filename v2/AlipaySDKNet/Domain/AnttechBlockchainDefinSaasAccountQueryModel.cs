using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasAccountQueryModel : AopObject
    {
        /// <summary>
        /// 账号状态过滤，默认查询所有状态账号； ACTIVE = 查询激活账号 INIT = 查询未激活账号
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 买家外部业务平台会员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public ReferenceId OutMemberId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
