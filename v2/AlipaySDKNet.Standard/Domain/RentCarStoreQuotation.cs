using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarStoreQuotation Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarStoreQuotation : AopObject
    {
        /// <summary>
        /// 评论数（取用户对商户评论数的总和）
        /// </summary>
        [XmlElement("comment_num")]
        public long CommentNum { get; set; }

        /// <summary>
        /// 评论内容，取用户对商户评论标签中最多的一个返回
        /// </summary>
        [XmlElement("comment_tag")]
        public string CommentTag { get; set; }

        /// <summary>
        /// 门店与用户的直线距离，单位米
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// isv优惠金额，单位分。仅用于展示，不会参与到优惠计算中
        /// </summary>
        [XmlElement("isv_discount_amount")]
        public long IsvDiscountAmount { get; set; }

        /// <summary>
        /// 门店纬度，高德坐标系
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店经度，高德坐标系
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 服务商当前车型、门店报价的id，用于从支付宝租车页面跳转到服务商页面时，准确定位车型、门店及价格数据
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 评论分数(取用户对商户评论分数的权重值：如平均值)，最低分4.0，最高分5.0
        /// </summary>
        [XmlElement("service_score")]
        public string ServiceScore { get; set; }

        /// <summary>
        /// 特色服务的列表，特色服务枚举值见 https://adccloud.yuque.com/adccloud/aqkbzc/bg8fiw#bO71H
        /// </summary>
        [XmlArray("special_services")]
        [XmlArrayItem("string")]
        public List<string> SpecialServices { get; set; }

        /// <summary>
        /// 三方系统中的门店id
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 在请求参数中如果传了用户购买随心租的订单id，则服务商需要判断哪些车型、门店可以使用哪些随心租
        /// </summary>
        [XmlArray("support_easy_card_order_ids")]
        [XmlArrayItem("string")]
        public List<string> SupportEasyCardOrderIds { get; set; }

        /// <summary>
        /// 单位分，例如总价100元，传10000。总价=日租金X日均价+其余费用（例如车辆整备费、基础服务费等）
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 日租金，单位分，例如日租金50元，传5000
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
