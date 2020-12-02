using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceConsultQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceConsultQueryResponse : AopObject
    {
        /// <summary>
        /// 支付宝侧服务咨询单号
        /// </summary>
        [XmlElement("consult_event_id")]
        public string ConsultEventId { get; set; }

        /// <summary>
        /// 咨询内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 咨询单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 咨询工单结束时间，当工单达到终态时，才会有结束时间
        /// </summary>
        [XmlElement("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 咨询工单修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 咨询图片
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 最近一笔商家订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 咨询人电话号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// 二级问题类型
        /// </summary>
        [XmlElement("second_question_type")]
        public string SecondQuestionType { get; set; }

        /// <summary>
        /// 状态 商家处理中：MERCHANT_PROCESSING 商家已回复： MERCHANT_REPLIED 已撤销： CANCELLED 系统关闭： CLOSED
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
        /// 最近一笔支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
