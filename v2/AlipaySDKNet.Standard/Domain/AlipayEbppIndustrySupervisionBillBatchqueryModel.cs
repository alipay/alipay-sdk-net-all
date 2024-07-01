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
        /// 不同的业务场景下对应不同的业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 查询的账单记录结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 本次查询账单的对应子户账户户号 对应开户接口 account.create 中返回的「子户账户户号 merchant_account_no」
        /// </summary>
        [XmlElement("merchant_account_no")]
        public string MerchantAccountNo { get; set; }

        /// <summary>
        /// 查询页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 驾培场景下该参数无效。只返回来帐记录。 专款钱包场景下根据该字段返回对应类型的记录
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 查询的账单记录开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
