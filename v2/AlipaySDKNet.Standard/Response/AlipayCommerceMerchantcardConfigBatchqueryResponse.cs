using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardConfigBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardConfigBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 安心付商户配置
        /// </summary>
        [XmlArray("axf_merchant_config_list")]
        [XmlArrayItem("axf_merchant_config")]
        public List<AxfMerchantConfig> AxfMerchantConfigList { get; set; }
    }
}
