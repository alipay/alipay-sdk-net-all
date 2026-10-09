using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DongCheDiDealerDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DongCheDiDealerDetail : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 经销商全称
        /// </summary>
        [XmlElement("dealer_full_name")]
        public string DealerFullName { get; set; }

        /// <summary>
        /// 经销商id
        /// </summary>
        [XmlElement("dealer_id")]
        public string DealerId { get; set; }

        /// <summary>
        /// 经销商名称
        /// </summary>
        [XmlElement("dealer_name")]
        public string DealerName { get; set; }

        /// <summary>
        /// 经销商类型
        /// </summary>
        [XmlElement("dealer_type")]
        public string DealerType { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 经销商最高报价单位：万元
        /// </summary>
        [XmlElement("max_dealer_price")]
        public string MaxDealerPrice { get; set; }

        /// <summary>
        /// 经销商最低报价单位：万元
        /// </summary>
        [XmlElement("min_dealer_price")]
        public string MinDealerPrice { get; set; }
    }
}
