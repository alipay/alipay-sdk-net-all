using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCustomerIdentifyResponse.
    /// </summary>
    public class AlipayUserCustomerIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 账户互通活动信息列表，目前支持的活动名称  PAYMENT_NEW_CUSTOMER, 支付拉新
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("alipay_user_cust_identify_activity")]
        public List<AlipayUserCustIdentifyActivity> ActivityList { get; set; }

        /// <summary>
        /// 用户画像信息，预留参数。返回用户画像信息，例如用户特征或者其他脱敏后的信息。
        /// </summary>
        [XmlElement("user_profile")]
        public string UserProfile { get; set; }
    }
}
