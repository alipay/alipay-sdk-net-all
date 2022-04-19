using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundUsertradeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundUsertradeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询交易数据场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 拉取的结算时间，格式yyyy-MM-dd HH:mm:ss，拉取逻辑包含该时刻。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页页码，从1开始，必须大于0
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页大小，必须大于0，最大设置100
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询交易数据产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 拉取的起始时间，格式yyyy-MM-dd HH:mm:ss，时间必须早于拉取的截止时间，并且，接口仅限查询用户30天内交易数据，拉取逻辑包含该时刻。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
