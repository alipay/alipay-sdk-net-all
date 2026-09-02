using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyBizflowBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyBizflowBatchqueryModel : AopObject
    {
        /// <summary>
        /// 按不同场景约定传入对应账户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 查询结束时间，必须大于开始时间，最大查询间隔需小于等于31天。返回结果日期小于等于2026-01-31 23:59:59
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 查询开始时间，返回结果日期大于等于2026-01-01 00:00:00
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 第一次查询为空，翻页查询取最后条记录的FlowNo
        /// </summary>
        [XmlElement("next_cursor")]
        public string NextCursor { get; set; }

        /// <summary>
        /// 每页10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 仅支持字母、数字，作为幂等字段，需保证在调用方内部不重复
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 由双方约定分配值
        /// </summary>
        [XmlElement("request_scene")]
        public string RequestScene { get; set; }
    }
}
