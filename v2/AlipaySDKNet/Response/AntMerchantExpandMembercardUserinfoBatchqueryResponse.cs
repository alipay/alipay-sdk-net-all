using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardUserinfoBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandMembercardUserinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 会员信息列表
        /// </summary>
        [XmlArray("user_info_list")]
        [XmlArrayItem("member_card_user_info")]
        public List<MemberCardUserInfo> UserInfoList { get; set; }
    }
}
