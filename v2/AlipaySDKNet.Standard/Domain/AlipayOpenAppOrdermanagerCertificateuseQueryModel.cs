using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOrdermanagerCertificateuseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOrdermanagerCertificateuseQueryModel : AopObject
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 需传入商家在支付宝侧生成的店铺id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 核销时间右区间，时间戳格式，查询时会包含本字段表示的时间
        /// </summary>
        [XmlElement("write_off_end")]
        public long WriteOffEnd { get; set; }

        /// <summary>
        /// 待查询的核销团购门店id列表
        /// </summary>
        [XmlArray("write_off_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> WriteOffShopIds { get; set; }

        /// <summary>
        /// 核销时间左区间，时间戳格式，查询时间范围会包含本字段对应的时间
        /// </summary>
        [XmlElement("write_off_start")]
        public long WriteOffStart { get; set; }

        /// <summary>
        /// 核销状态
        /// </summary>
        [XmlElement("write_off_status")]
        public string WriteOffStatus { get; set; }
    }
}
