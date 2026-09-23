using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckNoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CheckNoInfo : AopObject
    {
        /// <summary>
        /// 检查检验项目列表
        /// </summary>
        [XmlArray("check_item_list")]
        [XmlArrayItem("check_item")]
        public List<CheckItem> CheckItemList { get; set; }

        /// <summary>
        /// 医嘱单单号
        /// </summary>
        [XmlElement("check_no")]
        public string CheckNo { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss，待下单状态要提供
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 履约单号，下单以后需要
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 状态：1-待下单、2-已下单、3-已撤销、4-已失效、5-已到检
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 五种状态：待下单、已下单、已撤销、已失效、已到检
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 订单号，下单以后需要
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }

        /// <summary>
        /// 有效期结束时间戳
        /// </summary>
        [XmlElement("validity_end_time")]
        public long ValidityEndTime { get; set; }

        /// <summary>
        /// 有效期描述
        /// </summary>
        [XmlElement("validity_period_desc")]
        public string ValidityPeriodDesc { get; set; }
    }
}
