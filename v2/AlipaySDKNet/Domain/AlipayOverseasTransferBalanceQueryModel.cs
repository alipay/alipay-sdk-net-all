using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 账户别名
        /// </summary>
        [XmlElement("account_alias")]
        public string AccountAlias { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
