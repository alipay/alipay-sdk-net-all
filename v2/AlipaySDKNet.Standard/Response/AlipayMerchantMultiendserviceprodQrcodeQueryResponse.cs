using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMultiendserviceprodQrcodeQueryResponse.
    /// </summary>
    public class AlipayMerchantMultiendserviceprodQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("qrcode_white_list")]
        public List<QrcodeWhiteList> Items { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量，单位：条
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
