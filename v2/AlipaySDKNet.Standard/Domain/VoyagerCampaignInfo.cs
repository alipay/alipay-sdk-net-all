using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerCampaignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerCampaignInfo : AopObject
    {
        /// <summary>
        /// 用户是否可领（活动非进行中或券已用完时为 false）
        /// </summary>
        [XmlElement("available")]
        public bool Available { get; set; }

        /// <summary>
        /// 按钮文案
        /// </summary>
        [XmlElement("btn_text")]
        public string BtnText { get; set; }

        /// <summary>
        /// 按钮跳转地址
        /// </summary>
        [XmlElement("btn_url")]
        public string BtnUrl { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动状态：CAMP_GOING（进行中）/ CAMP_END（已结束）等
        /// </summary>
        [XmlElement("campaign_status")]
        public string CampaignStatus { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 扩展信息,json的字符串
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 活动展示图 URL
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 活动副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voucher_infos")]
        [XmlArrayItem("voyager_voucher_info")]
        public List<VoyagerVoucherInfo> VoucherInfos { get; set; }
    }
}
