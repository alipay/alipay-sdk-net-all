using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecordDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RecordDetail : AopObject
    {
        /// <summary>
        /// 消费说明
        /// </summary>
        [XmlElement("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 交易时间 yyyy-mm-dd HH:MM:SS
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }
    }
}
