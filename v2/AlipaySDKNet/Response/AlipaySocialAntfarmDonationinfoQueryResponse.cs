using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntfarmDonationinfoQueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmDonationinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前用户捐赠爱心记录
        /// </summary>
        [XmlArray("donation_list")]
        [XmlArrayItem("antfarm_user_donation_info")]
        public List<AntfarmUserDonationInfo> DonationList { get; set; }
    }
}
