using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreQuotation Data Structure.
    /// </summary>
    [Serializable]
    public class StoreQuotation : AopObject
    {
        /// <summary>
        /// 评论数（取用户对商户评论数的总和） N
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
        /// 门店坐标纬度，高德坐标系
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店坐标经度，高德坐标系
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商户自定义的报价id，通过这个id从车辆列表页跳转到订单页时商户可以准确定位门店、车辆。 由于这个字段是后续加的，并且车生活不消费此字段，所以是可选的，但是其实每个商户每个报价都是要传的，为了避免意外情况所以设置的可选。 由于大方用这个字段传递一些额外参数，所以暂时把最大长度设置为2000
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 评论分数(取用户对商户评论分数的权重值：如平均值)
        /// </summary>
        [XmlElement("service_score")]
        public string ServiceScore { get; set; }

        /// <summary>
        /// 特色服务标签列表
        /// </summary>
        [XmlArray("special_services")]
        [XmlArrayItem("string")]
        public List<string> SpecialServices { get; set; }

        /// <summary>
        /// 门店编码。长度设置100位的原因是哈啰回传的storeCode比较长，例如「2852480814313111552_121.809431_31.151069_1501897333010649089」。在哈啰已经接入并且不影响业务流程的情况下暂时保持现状
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
        /// 总价，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 日租金，单位分
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
