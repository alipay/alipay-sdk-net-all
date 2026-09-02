using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorWifiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorWifiQueryModel : AopObject
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// WIFI名称
        /// </summary>
        [XmlElement("wifi_name")]
        public string WifiName { get; set; }
    }
}
