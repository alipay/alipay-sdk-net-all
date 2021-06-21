using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantComplainGovernmentQueryResponse.
    /// </summary>
    public class AlipayMerchantComplainGovernmentQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 支付宝侧投诉工单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 用户投诉诉求原因
        /// </summary>
        [XmlElement("complain_reason")]
        public string ComplainReason { get; set; }

        /// <summary>
        /// 投诉内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 线下交易投诉创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 线下交易投诉工单结束时间，当工单达到终态时，才会有结束时间
        /// </summary>
        [XmlElement("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 投诉者申请平台接入（12315）的时间
        /// </summary>
        [XmlElement("gmt_intervene_platform")]
        public string GmtIntervenePlatform { get; set; }

        /// <summary>
        /// 线下交易投诉修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 用户提交投诉时提交的图片
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 用户投诉诉求类型名称
        /// </summary>
        [XmlElement("leaf_category_name")]
        public string LeafCategoryName { get; set; }

        /// <summary>
        /// 商家支付宝侧编号
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 投诉人电话号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 用户、商家、平台之间的沟通记录
        /// </summary>
        [XmlArray("reply_detail_infos")]
        [XmlArrayItem("reply_record_response")]
        public List<ReplyRecordResponse> ReplyDetailInfos { get; set; }

        /// <summary>
        /// 商家处理中：MERCHANT_PROCESSING   商家已处理：MERCHANT_FEEDBACKED   商家已处理超时：MERCHANT_FEEDBACK_OVERTIME  投诉已完结：FINISHED   已撤销： CANCELLED   系统关闭： CLOSED  平台处理中： PLATFORM_PROCESSING  平台处理完结：PLATFORM_FINISH
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易订单金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易商品名称
        /// </summary>
        [XmlElement("trade_product_name")]
        public string TradeProductName { get; set; }

        /// <summary>
        /// 交易成功时间
        /// </summary>
        [XmlElement("trade_succeed_time")]
        public string TradeSucceedTime { get; set; }
    }
}
