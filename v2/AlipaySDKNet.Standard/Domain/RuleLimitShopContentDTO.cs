using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleLimitShopContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RuleLimitShopContentDTO : AopObject
    {
        /// <summary>
        /// 商圈物理门店ID
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 商圈物理门店名称
        /// </summary>
        [XmlElement("real_shop_name")]
        public string RealShopName { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }
    }
}
