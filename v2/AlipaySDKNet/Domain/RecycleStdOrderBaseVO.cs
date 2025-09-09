using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleStdOrderBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleStdOrderBaseVO : AopObject
    {
        /// <summary>
        /// 若固定金额，则只有assess_max_amount.   旧衣统收场景下，区间报价。存在“最小100元”的报价，即只有assess_min_amount
        /// </summary>
        [XmlElement("assess_max_amount")]
        public string AssessMaxAmount { get; set; }

        /// <summary>
        /// 估价最小金额
        /// </summary>
        [XmlElement("assess_min_amount")]
        public string AssessMinAmount { get; set; }

        /// <summary>
        /// FIXED:固定报价 区间报价:RANGE_UNIT\RANGE_PRICE
        /// </summary>
        [XmlElement("assess_price_type")]
        public string AssessPriceType { get; set; }

        /// <summary>
        /// 估价产品列表
        /// </summary>
        [XmlArray("assess_products")]
        [XmlArrayItem("recycle_assess_product_v_o")]
        public List<RecycleAssessProductVO> AssessProducts { get; set; }

        /// <summary>
        /// 回收商订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 交易订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("order_memo")]
        public string OrderMemo { get; set; }

        /// <summary>
        /// 订单更新时间
        /// </summary>
        [XmlElement("order_modify_time")]
        public string OrderModifyTime { get; set; }

        /// <summary>
        /// 回收订单状态，详细参见回收订单状态机
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 回收行业类别
        /// </summary>
        [XmlElement("recycle_category")]
        public string RecycleCategory { get; set; }

        /// <summary>
        /// 商户质检确认后的最终报价金额。相较于估价，此金额一定是固定金额
        /// </summary>
        [XmlElement("user_total_amount")]
        public string UserTotalAmount { get; set; }
    }
}
