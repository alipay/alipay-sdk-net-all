using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardUserinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardUserinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商家的安心充配置的唯一编号
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 查询的页数，从1开始，最大1000
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，最小1，最大20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
