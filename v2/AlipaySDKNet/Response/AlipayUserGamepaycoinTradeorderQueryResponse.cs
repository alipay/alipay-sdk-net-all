using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamepaycoinTradeorderQueryResponse.
    /// </summary>
    public class AlipayUserGamepaycoinTradeorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易订单虚拟币数量(个)
        /// </summary>
        [XmlElement("bill_amount")]
        public long BillAmount { get; set; }

        /// <summary>
        /// 开发者备注
        /// </summary>
        [XmlElement("cp_extra")]
        public string CpExtra { get; set; }

        /// <summary>
        /// 道具名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 交易退款虚拟币数量(个)，未发生退款时为0
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 交易订单支付状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分区id
        /// </summary>
        [XmlElement("zone_id")]
        public string ZoneId { get; set; }
    }
}
