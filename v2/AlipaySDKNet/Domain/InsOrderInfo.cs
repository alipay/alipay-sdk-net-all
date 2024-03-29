using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsOrderInfo : AopObject
    {
        /// <summary>
        /// 业务字段
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 卖家接单时间
        /// </summary>
        [XmlElement("order_accept_time")]
        public string OrderAcceptTime { get; set; }

        /// <summary>
        /// 订单实付金额(单位:分)
        /// </summary>
        [XmlElement("order_actual_fee")]
        public long OrderActualFee { get; set; }

        /// <summary>
        /// 1593329026000
        /// </summary>
        [XmlElement("order_expected_time")]
        public string OrderExpectedTime { get; set; }

        /// <summary>
        /// 订单完结时间
        /// </summary>
        [XmlElement("order_finish_time")]
        public string OrderFinishTime { get; set; }

        /// <summary>
        /// 饿了么订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态 INIT:初始化  FINSHED:已完结 备注:枚举非强制，可以使用外部枚举
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单下单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }
    }
}
