using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherGenerateModel : AopObject
    {
        /// <summary>
        /// 城市编码请参考查询 <a href="http://www.mca.gov.cn/article/sj/xzqh/">中华人民共和国行政区划代码</a>。 已支持城市：广州 440100，深圳 440300，杭州330100。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 起点站站点编码
        /// </summary>
        [XmlElement("site_begin")]
        public string SiteBegin { get; set; }

        /// <summary>
        /// 终点站站点编码
        /// </summary>
        [XmlElement("site_end")]
        public string SiteEnd { get; set; }

        /// <summary>
        /// 地铁票购票数量
        /// </summary>
        [XmlElement("ticket_num")]
        public string TicketNum { get; set; }

        /// <summary>
        /// 单张票价，元为单价
        /// </summary>
        [XmlElement("ticket_price")]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 地铁票种类，枚举支持： *oneway。
        /// </summary>
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 订单总金额，元为单位
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 支付宝交易号（交易支付时，必须通过指定sellerId：2088121612215201，将钱支付到指定的中间户中）
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
