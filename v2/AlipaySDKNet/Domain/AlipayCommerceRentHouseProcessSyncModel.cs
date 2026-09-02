using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentHouseProcessSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentHouseProcessSyncModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 大订单系统ID，可关联多个小二订单
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 租房agent派单的id，来源于商户接单时的id，用于关于商家接单任务
        /// </summary>
        [XmlElement("dispatch_id")]
        public string DispatchId { get; set; }

        /// <summary>
        /// 房源在平台的唯一标识，（租房系统）来自房源创建接口的返回值
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 外部业务单号，用于关联短租交易方案
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务单标题
        /// </summary>
        [XmlElement("out_biz_title")]
        public string OutBizTitle { get; set; }

        /// <summary>
        /// 前序过程记录ID，首次提报时为null
        /// </summary>
        [XmlElement("prev_process_id")]
        public string PrevProcessId { get; set; }

        /// <summary>
        /// 过程发生时间
        /// </summary>
        [XmlElement("process_time")]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 租住过程
        /// </summary>
        [XmlElement("rental_process")]
        public string RentalProcess { get; set; }

        /// <summary>
        /// 服务推进补充信息
        /// </summary>
        [XmlElement("service_detail")]
        public ServiceDetailE ServiceDetail { get; set; }

        /// <summary>
        /// 交易补充信息
        /// </summary>
        [XmlElement("trade_detail")]
        public TradeDetailE TradeDetail { get; set; }

        /// <summary>
        /// 租房订单类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
