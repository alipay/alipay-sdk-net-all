using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderDigestConsumerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderDigestConsumerBatchqueryModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 结束时间，格式为：yyyy-MM-dd hh:mm:ss  查询返回的订单支付时间在end_time之前，不包括end_time  注：为了避免数据重复，可在start_time不变的情况下利用上一次返回中的next_end_time作为下一次end_time的入参，实现分页查询
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询订单信息，该订单属于请求pid以及传入的appid    注：若为空，则返回订单列表不按照appid进行筛选
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 所需查询的订单来源  取值范围：  ALL-全部订单来源  TINY_APP-来自小程序的订单（默认值）    注：使用该字段前请咨询接口owner
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 查询条数  取值范围：[1,50]    注：若start_time与end_time之间的总条数大于size，则按照订单支付时间倒序取前size条；若总条数小于size，则按照订单支付时间倒序，返回实际条数
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 查询开始时间，格式为：yyyy-MM-dd hh:mm:ss    查询返回的订单支付时间在start_time之后，包括start_time
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
