using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationDcsMerchantqrcodeQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationDcsMerchantqrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝进件商户PID, 仅支持进件绑码过查询
        /// </summary>
        [XmlElement("apply_merchant_pid")]
        public string ApplyMerchantPid { get; set; }

        /// <summary>
        /// 直连商户:pid，间联商户:smid
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色ID集合, 直连商户:pid，间联商户:smid
        /// </summary>
        [XmlArray("role_ids")]
        [XmlArrayItem("string")]
        public List<string> RoleIds { get; set; }
    }
}
