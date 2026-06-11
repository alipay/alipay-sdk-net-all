using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyWalletBindroleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyWalletBindroleModifyModel : AopObject
    {
        /// <summary>
        /// 绑定场景
        /// </summary>
        [XmlElement("bind_scene")]
        public string BindScene { get; set; }

        /// <summary>
        /// 标识一次单独的接口调用，用于接口幂等处理和问题排查的索引
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 钱包编号
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
