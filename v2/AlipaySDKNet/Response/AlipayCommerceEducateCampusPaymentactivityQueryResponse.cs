using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusPaymentactivityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusPaymentactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行机构id列表
        /// </summary>
        [XmlArray("inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstIdList { get; set; }

        /// <summary>
        /// 是否报名校园支付银行优惠活动
        /// </summary>
        [XmlElement("sign_up")]
        public bool SignUp { get; set; }
    }
}
