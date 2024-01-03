using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcassetscenterMerchantbaseinfoQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcassetscenterMerchantbaseinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家基础信息响应列表
        /// </summary>
        [XmlArray("merchant_base_info_list")]
        [XmlArrayItem("merchant_base_info_response")]
        public List<MerchantBaseInfoResponse> MerchantBaseInfoList { get; set; }
    }
}
