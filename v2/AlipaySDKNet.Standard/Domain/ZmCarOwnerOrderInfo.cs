using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCarOwnerOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCarOwnerOrderInfo : AopObject
    {
        /// <summary>
        /// 由合作方生成的标识唯一一笔订单的编号
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 订单状态： 乘客上车/到达
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 合作方当前顺风车主已成功完成的订单量
        /// </summary>
        [XmlElement("service_order_cnt")]
        public long ServiceOrderCnt { get; set; }
    }
}
