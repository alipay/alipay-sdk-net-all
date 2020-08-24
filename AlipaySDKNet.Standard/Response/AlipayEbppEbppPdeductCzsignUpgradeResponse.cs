using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEbppPdeductCzsignUpgradeResponse.
    /// </summary>
    public class AlipayEbppEbppPdeductCzsignUpgradeResponse : AopResponse
    {
        /// <summary>
        /// 错误信息文案
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 升级后新的协议ID
        /// </summary>
        [XmlElement("new_agreement_id")]
        public string NewAgreementId { get; set; }

        /// <summary>
        /// 当前更新结果是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
