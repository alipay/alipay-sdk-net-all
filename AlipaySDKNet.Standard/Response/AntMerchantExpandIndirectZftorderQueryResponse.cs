using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 直付通二级商户进件申请单信息
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("zft_sub_merchant_order")]
        public List<ZftSubMerchantOrder> Orders { get; set; }
    }
}
