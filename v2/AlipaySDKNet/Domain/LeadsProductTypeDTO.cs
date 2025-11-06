using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsProductTypeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsProductTypeDTO : AopObject
    {
        /// <summary>
        /// 维保开始时间
        /// </summary>
        [XmlElement("activation_start_date_time")]
        public string ActivationStartDateTime { get; set; }

        /// <summary>
        /// 维保结束时间
        /// </summary>
        [XmlElement("amortization_end_date_time")]
        public string AmortizationEndDateTime { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 主键或唯一ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("offline_commodity_description")]
        public string OfflineCommodityDescription { get; set; }

        /// <summary>
        /// 产品模式
        /// </summary>
        [XmlElement("product_model")]
        public string ProductModel { get; set; }
    }
}
