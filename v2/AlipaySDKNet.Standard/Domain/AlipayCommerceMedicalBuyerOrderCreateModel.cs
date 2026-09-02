using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBuyerOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBuyerOrderCreateModel : AopObject
    {
        /// <summary>
        /// 应用类型端 (支付宝，阿福)
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item_infos")]
        public List<ItemInfos> Items { get; set; }

        /// <summary>
        /// 就诊人id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("seller")]
        public string Seller { get; set; }

        /// <summary>
        /// 服务项信息
        /// </summary>
        [XmlElement("service_package")]
        public ServicePackageInfo ServicePackage { get; set; }

        /// <summary>
        /// 订单来源，传advisor_proxy
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
