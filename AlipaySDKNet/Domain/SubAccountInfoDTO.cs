using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountInfoDTO : AopObject
    {
        /// <summary>
        /// 开户状态 ACCEPTED: 受理成功状态，尚未发起开户 OPENING: 子户开通中，等待开户结果 SUCCESS: 子户开通成功状态，子户信息可查询 OPEN_FAILED: 开户失败，需重新发起
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 子户以及其绑定信息 只有当状态为SUCCESS时该参数才存在
        /// </summary>
        [XmlElement("sub_account_info")]
        public SubAccountAndBindDTO SubAccountInfo { get; set; }
    }
}
