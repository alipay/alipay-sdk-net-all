using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class BookOrderVO : AopObject
    {
        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 外部预约订单号，服务商下唯—
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单状态:31-待接种，91-已接种，81-已取消
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 外部医院id，服务商下唯—
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
