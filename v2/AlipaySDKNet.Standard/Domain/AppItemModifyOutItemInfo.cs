using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemModifyOutItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemModifyOutItemInfo : AopObject
    {
        /// <summary>
        /// 商品小程序appId
        /// </summary>
        [XmlElement("item_app_id")]
        public string ItemAppId { get; set; }

        /// <summary>
        /// 需要查询优惠信息的商品商家侧ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
