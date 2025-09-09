using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarQuoteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarQuoteInfo : AopObject
    {
        /// <summary>
        /// spu下报价排序
        /// </summary>
        [XmlElement("amt_rank_sort")]
        public string AmtRankSort { get; set; }

        /// <summary>
        /// 租车车类型
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 和最优价价差之和(单位元)
        /// </summary>
        [XmlElement("diff_adv_quote_amt")]
        public string DiffAdvQuoteAmt { get; set; }

        /// <summary>
        /// 行程结束详情地址
        /// </summary>
        [XmlElement("end_address")]
        public string EndAddress { get; set; }

        /// <summary>
        /// 行程结束城市名
        /// </summary>
        [XmlElement("end_city_name")]
        public string EndCityName { get; set; }

        /// <summary>
        /// 行程结束纬度
        /// </summary>
        [XmlElement("end_latitude")]
        public string EndLatitude { get; set; }

        /// <summary>
        /// 行程结束经度
        /// </summary>
        [XmlElement("end_longitude")]
        public string EndLongitude { get; set; }

        /// <summary>
        /// 行程结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 实际支付价格(单位元,扣除券后价格)
        /// </summary>
        [XmlElement("sku_actual_amt")]
        public string SkuActualAmt { get; set; }

        /// <summary>
        /// 日均单价(单位元)
        /// </summary>
        [XmlElement("sku_avg_amt")]
        public string SkuAvgAmt { get; set; }

        /// <summary>
        /// sku车辆ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 门店名
        /// </summary>
        [XmlElement("sku_sname")]
        public string SkuSname { get; set; }

        /// <summary>
        /// 优惠前总价（单位元）
        /// </summary>
        [XmlElement("sku_total_amt")]
        public string SkuTotalAmt { get; set; }

        /// <summary>
        /// spu车型ID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// spu车型名称
        /// </summary>
        [XmlElement("spu_name")]
        public string SpuName { get; set; }

        /// <summary>
        /// 行程开始详情地址
        /// </summary>
        [XmlElement("start_address")]
        public string StartAddress { get; set; }

        /// <summary>
        /// 行程开始城市名
        /// </summary>
        [XmlElement("start_city_name")]
        public string StartCityName { get; set; }

        /// <summary>
        /// 行程开始纬度
        /// </summary>
        [XmlElement("start_latitude")]
        public string StartLatitude { get; set; }

        /// <summary>
        /// 行程开始经度
        /// </summary>
        [XmlElement("start_longitude")]
        public string StartLongitude { get; set; }

        /// <summary>
        /// 行程开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("trace_datetime")]
        public string TraceDatetime { get; set; }
    }
}
