using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoContractMerchantSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoContractMerchantSyncModel : AopObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 商家配置信息
        /// </summary>
        [XmlArray("merchant_configs")]
        [XmlArrayItem("merchant_config_request")]
        public List<MerchantConfigRequest> MerchantConfigs { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [XmlElement("sign_platform_code")]
        public string SignPlatformCode { get; set; }
    }
}
