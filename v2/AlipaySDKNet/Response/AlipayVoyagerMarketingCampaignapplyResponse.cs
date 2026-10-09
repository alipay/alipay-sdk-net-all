using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingCampaignapplyResponse.
    /// </summary>
    public class AlipayVoyagerMarketingCampaignapplyResponse : AopResponse
    {
        /// <summary>
        /// 活动申领号
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voucher_vos")]
        [XmlArrayItem("voyager_voucher_v_o")]
        public List<VoyagerVoucherVO> VoucherVos { get; set; }
    }
}
