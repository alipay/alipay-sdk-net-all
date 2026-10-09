using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollContent Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollContent : AopObject
    {
        /// <summary>
        /// 报名提交的小程序商品列表。
        /// </summary>
        [XmlArray("app_items")]
        [XmlArrayItem("recruit_content_app_item")]
        public List<RecruitContentAppItem> AppItems { get; set; }

        /// <summary>
        /// 报名提交的小程序列表。
        /// </summary>
        [XmlArray("mini_apps")]
        [XmlArrayItem("recruit_content_mini_app")]
        public List<RecruitContentMiniApp> MiniApps { get; set; }

        /// <summary>
        /// 报名提交的券活动列表。
        /// </summary>
        [XmlArray("voucher_activities")]
        [XmlArrayItem("recruit_content_voucher_activity")]
        public List<RecruitContentVoucherActivity> VoucherActivities { get; set; }
    }
}
