using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceExtCommentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceExtCommentBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当传递该字段时候、查询指定日期天所在的订单评价数据、若不传递该字段则默认查询调用接口所在时刻的前一天的订单评价数据
        /// </summary>
        [XmlElement("cmt_create_time")]
        public string CmtCreateTime { get; set; }

        /// <summary>
        /// 分页查询的当前页号,从1开始
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页查询的单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
