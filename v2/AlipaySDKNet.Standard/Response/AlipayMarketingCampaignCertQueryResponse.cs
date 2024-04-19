using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCertQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCertQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户还有效的凭证详细列表
        /// </summary>
        [XmlArray("subcert_list")]
        [XmlArrayItem("kn_cert_send_order_detail")]
        public List<KnCertSendOrderDetail> SubcertList { get; set; }

        /// <summary>
        /// 总的真正还可用的剩余有效点数
        /// </summary>
        [XmlElement("total_remain_point")]
        public long TotalRemainPoint { get; set; }
    }
}
