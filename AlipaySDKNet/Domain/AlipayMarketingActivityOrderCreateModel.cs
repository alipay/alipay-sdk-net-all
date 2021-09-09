using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrderCreateModel : AopObject
    {
        /// <summary>
        /// 购买者的支付宝uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 推广渠道信息。 由支付宝公私域跳转到服务商小程序时带入。例如 aalipays://platformapi/startapp?appId=2021002147682XXX&page=pages/main/mian&query=chInfo%3DchInfo_promotion 其中chInfo为支付宝带入投放渠道信息，需要在调用下单接口时传入
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 外部业务订单号。  同时具备幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 售卖活动信息列表。  目前只支持 sale_activity_info_list  中传入单个类型的活动信息。
        /// </summary>
        [XmlArray("sale_activity_info_list")]
        [XmlArrayItem("sale_activity_info")]
        public List<SaleActivityInfo> SaleActivityInfoList { get; set; }

        /// <summary>
        /// 商品订单总金额.  该总金额必须等于 sale_activity_info_list中所有商品单价*数量的总和。  支付宝内部会进行金额一致性检查。 保障用户下单看到的金额，和实际支付显示的金额保持一致。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
