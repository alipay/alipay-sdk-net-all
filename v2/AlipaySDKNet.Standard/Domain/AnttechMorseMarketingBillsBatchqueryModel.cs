using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingBillsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingBillsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务唯一标识码，摩斯侧分配
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 分页查询当前页数，取值区间：[1,无穷]，查询页没有值则标识后期没有数据可以不用再查询了
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询每页的个数，默认10条，取值区间：[1,50]，不在这个区间内，采用默认条数10.
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询对象的交易日期，格式为yyyyMMdd
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }
    }
}
