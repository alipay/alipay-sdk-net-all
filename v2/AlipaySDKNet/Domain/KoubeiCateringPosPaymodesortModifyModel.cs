using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodesortModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodesortModifyModel : AopObject
    {
        /// <summary>
        /// 支付方式名称列表
        /// </summary>
        [XmlArray("pay_names")]
        [XmlArrayItem("string")]
        public List<string> PayNames { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
