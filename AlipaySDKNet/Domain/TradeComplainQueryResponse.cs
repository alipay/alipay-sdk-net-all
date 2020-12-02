using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeComplainQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TradeComplainQueryResponse : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 投诉原因
        /// </summary>
        [XmlElement("complain_reason")]
        public string ComplainReason { get; set; }

        /// <summary>
        /// 已经扣除了我的钱，为什么再次扣款？？？
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 投诉单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 投诉单结束时间
        /// </summary>
        [XmlElement("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 投诉单修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投诉图片
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 投诉诉求
        /// </summary>
        [XmlElement("leaf_category_name")]
        public string LeafCategoryName { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 投诉人电话号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 状态 商家处理中：MERCHANT_PROCESSING 商家已反馈：MERCHANT_FEEDBACKED 投诉已完结：FINISHED 投诉已撤销：CANCELLED 平台处理中：PLATFORM_PROCESSING 平台处理完结：PLATFORM_FINISH 系统关闭：CLOSED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用id，例如小程序id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 小程序为：APPID 生活号为：PUBLICID
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
