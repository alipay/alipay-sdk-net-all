using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniBillDailyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBillDailyQueryModel : AopObject
    {
        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 结算日期，格式：yyyyMMdd。核销日期、结算日期2选1必传。如同时传入2个日期，则按核销日期查询返回账单明细。
        /// </summary>
        [XmlElement("settle_date")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 核销日期，格式：yyyyMMdd。核销日期、结算日期2选1必传。如同时传入2个日期，则按核销日期查询返回账单明细。
        /// </summary>
        [XmlElement("use_date")]
        public string UseDate { get; set; }
    }
}
