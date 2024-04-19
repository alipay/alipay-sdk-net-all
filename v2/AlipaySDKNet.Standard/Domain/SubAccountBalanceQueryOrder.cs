using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountBalanceQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountBalanceQueryOrder : AopObject
    {
        /// <summary>
        /// 子户识别基本信息
        /// </summary>
        [XmlElement("sub_account_base_info")]
        public SubAccountBaseInfo SubAccountBaseInfo { get; set; }
    }
}
