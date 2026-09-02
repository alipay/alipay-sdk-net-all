using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmItemQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有免费权益
        /// </summary>
        [XmlElement("has_free")]
        public bool HasFree { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_item_list")]
        [XmlArrayItem("service_item")]
        public List<ServiceItem> ServiceItemList { get; set; }

        /// <summary>
        /// 服务包ID
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// 服务包名称
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }

        /// <summary>
        /// 服务包订单ID
        /// </summary>
        [XmlElement("service_package_order_id")]
        public string ServicePackageOrderId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
