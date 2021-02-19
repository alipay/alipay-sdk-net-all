using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherBatchqueryModel : AopObject
    {
        /// <summary>
        /// 城市编码请参考查询 <a href="http://www.mca.gov.cn/article/sj/xzqh/">中华人民共和国行政区划代码</a>。 已支持城市：广州 440100，深圳 440300，杭州330100。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝交易号列表
        /// </summary>
        [XmlArray("trade_nos")]
        [XmlArrayItem("string")]
        public List<string> TradeNos { get; set; }
    }
}
