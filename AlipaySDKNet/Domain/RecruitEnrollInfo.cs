using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollInfo : AopObject
    {
        /// <summary>
        /// 报名商户
        /// </summary>
        [XmlElement("enroll_merchant")]
        public RecruitEnrollMerchant EnrollMerchant { get; set; }

        /// <summary>
        /// 报名需要提交的素材
        /// </summary>
        [XmlArray("materials")]
        [XmlArrayItem("recruit_material")]
        public List<RecruitMaterial> Materials { get; set; }

        /// <summary>
        /// 报名提交的小程序信息，是否必选取决于方案要求
        /// </summary>
        [XmlArray("mini_apps")]
        [XmlArrayItem("recruit_mini_app")]
        public List<RecruitMiniApp> MiniApps { get; set; }

        /// <summary>
        /// 报名提交的券信息，是否必选取决于方案要求
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("recruit_voucher")]
        public List<RecruitVoucher> Vouchers { get; set; }
    }
}
