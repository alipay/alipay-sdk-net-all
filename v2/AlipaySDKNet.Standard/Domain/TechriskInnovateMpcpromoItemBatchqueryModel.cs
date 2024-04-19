using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 被授权小程序的appId
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 店铺code
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
