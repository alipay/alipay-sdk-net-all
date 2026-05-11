using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductInfoClasses Data Structure.
    /// </summary>
    [Serializable]
    public class ProductInfoClasses : AopObject
    {
        /// <summary>
        /// 产品介绍文件集合
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("file_info_classes")]
        public List<FileInfoClasses> FileList { get; set; }

        /// <summary>
        /// 电商店铺信息
        /// </summary>
        [XmlArray("online_store_info_list")]
        [XmlArrayItem("online_shop_classes")]
        public List<OnlineShopClasses> OnlineStoreInfoList { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [XmlElement("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 服务落地链接
        /// </summary>
        [XmlArray("service_url")]
        [XmlArrayItem("string")]
        public List<string> ServiceUrl { get; set; }
    }
}
