using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfarmUserDonationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AntfarmUserDonationInfo : AopObject
    {
        /// <summary>
        /// 用户捐爱心记录列表
        /// </summary>
        [XmlArray("donation_record_list")]
        [XmlArrayItem("antfarm_user_donation_record")]
        public List<AntfarmUserDonationRecord> DonationRecordList { get; set; }

        /// <summary>
        /// 捐赠标的物 id
        /// </summary>
        [XmlElement("donation_target_id")]
        public string DonationTargetId { get; set; }

        /// <summary>
        /// 捐赠标的物名称
        /// </summary>
        [XmlElement("donation_target_name")]
        public string DonationTargetName { get; set; }

        /// <summary>
        /// 捐赠项目 id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 捐赠项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
