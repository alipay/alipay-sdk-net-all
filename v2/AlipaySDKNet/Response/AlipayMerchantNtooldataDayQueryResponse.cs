using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantNtooldataDayQueryResponse.
    /// </summary>
    public class AlipayMerchantNtooldataDayQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备相关数据列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("merchant_ndata")]
        public List<MerchantNdata> Data { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 数据统计时间
        /// </summary>
        [XmlElement("metrics_date")]
        public string MetricsDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
