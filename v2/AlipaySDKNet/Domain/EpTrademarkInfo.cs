using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpTrademarkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpTrademarkInfo : AopObject
    {
        /// <summary>
        /// 申请人地址中文
        /// </summary>
        [XmlElement("address_cn")]
        public string AddressCn { get; set; }

        /// <summary>
        /// 代理/办理机构
        /// </summary>
        [XmlElement("agent")]
        public string Agent { get; set; }

        /// <summary>
        /// 初审公告日期
        /// </summary>
        [XmlElement("announcement_date")]
        public string AnnouncementDate { get; set; }

        /// <summary>
        /// 初审公告期号
        /// </summary>
        [XmlElement("announcement_issue")]
        public string AnnouncementIssue { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [XmlElement("app_date")]
        public string AppDate { get; set; }

        /// <summary>
        /// 申请人名称中文
        /// </summary>
        [XmlElement("applicant_cn")]
        public string ApplicantCn { get; set; }

        /// <summary>
        /// 商标类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 国际分类
        /// </summary>
        [XmlElement("intl_cls")]
        public string IntlCls { get; set; }

        /// <summary>
        /// 是否共有商标
        /// </summary>
        [XmlElement("jointly_owned_trademark")]
        public bool JointlyOwnedTrademark { get; set; }

        /// <summary>
        /// 商标图片地址。链接地址1个小时内有效
        /// </summary>
        [XmlElement("logo_oss_path")]
        public string LogoOssPath { get; set; }

        /// <summary>
        /// 商标名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 专有权期限结束日期
        /// </summary>
        [XmlElement("private_date_end")]
        public string PrivateDateEnd { get; set; }

        /// <summary>
        /// 专有权期限开始日期
        /// </summary>
        [XmlElement("private_date_start")]
        public string PrivateDateStart { get; set; }

        /// <summary>
        /// 注册公告日期
        /// </summary>
        [XmlElement("reg_date")]
        public string RegDate { get; set; }

        /// <summary>
        /// 注册公告期号
        /// </summary>
        [XmlElement("reg_issue")]
        public string RegIssue { get; set; }

        /// <summary>
        /// 申请或注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 商品/服务项目
        /// </summary>
        [XmlArray("second_class_code")]
        [XmlArrayItem("ep_trademark_second_class_code_info")]
        public List<EpTrademarkSecondClassCodeInfo> SecondClassCode { get; set; }

        /// <summary>
        /// 商标状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
