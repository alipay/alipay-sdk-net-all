using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceVoucherTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceVoucherTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 页数，起始页是1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页的条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 券模版的起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 发行人用户id，2088账号
        /// </summary>
        [XmlElement("voucher_owner_id")]
        public string VoucherOwnerId { get; set; }
    }
}
