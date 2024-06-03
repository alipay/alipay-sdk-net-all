using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionBillBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionBillBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// YYYYMMDD 专款钱包场景下 为 yyyyMMddHHmmss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 企业监管子户账号
        /// </summary>
        [XmlElement("merchant_account_no")]
        public string MerchantAccountNo { get; set; }

        /// <summary>
        /// 查询分页开始索引，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小 1
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 驾培场景下该参数无效。只返回来帐记录。 专款钱包场景下根据该字段返回对应类型的记录
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// YYYYMMDD  专款钱包场景下 为 yyyyMMddHHmmss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
