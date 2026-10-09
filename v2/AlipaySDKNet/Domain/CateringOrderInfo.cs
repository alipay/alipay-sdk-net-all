using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringOrderInfo : AopObject
    {
        /// <summary>
        /// 点餐首页
        /// </summary>
        [XmlElement("merchant_home_url")]
        public string MerchantHomeUrl { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_num")]
        public string TableNum { get; set; }
    }
}
