using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundActivityInfo : AopObject
    {
        /// <summary>
        /// 待退款的活动id。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 待退款的数量。  由于目前支付宝只支持下单时购买1个商品，因此退款也只支持数量为1的退款。
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 待失效的券码列表。  退款时传入的券码数量必须和 quantity一致。  单个code最长64位
        /// </summary>
        [XmlArray("voucher_code_list")]
        [XmlArrayItem("string")]
        public List<string> VoucherCodeList { get; set; }
    }
}
