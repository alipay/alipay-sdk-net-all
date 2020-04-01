using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillMinimctSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWaybillMinimctSyncModel : AopObject
    {
        /// <summary>
        /// 物流公司编码，具体详见接口开发文档
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 运单参数扩展列表
        /// </summary>
        [XmlArray("merchant_ext_info")]
        [XmlArrayItem("param_ext_info")]
        public List<ParamExtInfo> MerchantExtInfo { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
