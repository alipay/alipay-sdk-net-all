using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInviteOrderQueryResponse.
    /// </summary>
    public class AlipayOpenInviteOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家支付宝账号对应的ID，2088开头
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 产品签约状态对象
        /// </summary>
        [XmlArray("sign_status_list")]
        [XmlArrayItem("product_invite_status_info")]
        public List<ProductInviteStatusInfo> SignStatusList { get; set; }
    }
}
