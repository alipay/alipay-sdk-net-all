using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoItemBatchqueryResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item_list")]
        public MpcItemVO ItemList { get; set; }

        /// <summary>
        /// 每页商品数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 授权店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺商品总数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
