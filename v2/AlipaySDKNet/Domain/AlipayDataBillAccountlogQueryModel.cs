using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillAccountlogQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillAccountlogQueryModel : AopObject
    {
        /// <summary>
        /// 协议授权码，特殊场景下使用
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议产品码。特殊场景下使用
        /// </summary>
        [XmlElement("agreement_product_code")]
        public string AgreementProductCode { get; set; }

        /// <summary>
        /// 支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 指定用户做账单查询
        /// </summary>
        [XmlElement("bill_user_id")]
        public string BillUserId { get; set; }

        /// <summary>
        /// 账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间。精确查询不需要指定
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000，默认2000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务流水创建时间的起始范围。只能查询一年内的记录。精确查询不需要指定
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 账务的类型代码，特殊场景下使用
        /// </summary>
        [XmlElement("trans_code")]
        public string TransCode { get; set; }
    }
}
