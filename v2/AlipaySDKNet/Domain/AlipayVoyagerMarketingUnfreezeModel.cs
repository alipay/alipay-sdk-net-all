using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingUnfreezeModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("benefit_use_infos")]
        [XmlArrayItem("benefit_use_v_o")]
        public List<BenefitUseVO> BenefitUseInfos { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务单号（原冻结时的 bizNo）
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 用户 openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户 2088 UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
