using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectModifyResponse.
    /// </summary>
    public class AntMerchantExpandIndirectModifyResponse : AopResponse
    {
        /// <summary>
        /// 可用服务，列表返回</br> PC：网站支付</br> APP：无线支付</br> F2F：当面付</br> PRE_F2F：线下预授权</br> PRE_APP：线上预授权</br> 返回为空为不支持所有服务
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// 申请业务失败原因
        /// </summary>
        [XmlElement("service_fail_reason")]
        public string ServiceFailReason { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
