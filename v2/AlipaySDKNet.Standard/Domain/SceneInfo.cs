using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SceneInfo : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 企业名
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 是否雇主（企业）访问
        /// </summary>
        [XmlElement("employer_visit")]
        public string EmployerVisit { get; set; }

        /// <summary>
        /// 所属类目（最终归属的行业）
        /// </summary>
        [XmlElement("job_category")]
        public string JobCategory { get; set; }

        /// <summary>
        /// 岗位所属类目及ID
        /// </summary>
        [XmlElement("job_category_id")]
        public string JobCategoryId { get; set; }

        /// <summary>
        /// 岗位ID
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 发生时间的时间戳
        /// </summary>
        [XmlElement("scene_time")]
        public string SceneTime { get; set; }

        /// <summary>
        /// 是否自己访问
        /// </summary>
        [XmlElement("self_visit")]
        public string SelfVisit { get; set; }

        /// <summary>
        /// 数据来源，当前分为 zmJobCenter（数据来自工作证招聘场的点击）和 ka(合作商户的数据)
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 数据的类型，当前暂时为edu(培训) 和 job(招聘)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
