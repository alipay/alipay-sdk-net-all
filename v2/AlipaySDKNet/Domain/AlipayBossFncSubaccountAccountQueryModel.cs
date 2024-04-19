using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSubaccountAccountQueryModel : AopObject
    {
        /// <summary>
        /// 子户信息查询请求
        /// </summary>
        [XmlElement("sub_account_info_query_order")]
        public SubAccountInfoQueryOrder SubAccountInfoQueryOrder { get; set; }
    }
}
