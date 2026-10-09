using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpZtbReportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpZtbReportCreateModel : AopObject
    {
        /// <summary>
        /// 招标类型，属于多种类型的话，用-拼接。例如采购中标-工程中标-服务中标
        /// </summary>
        [XmlElement("bid_type")]
        public string BidType { get; set; }

        /// <summary>
        /// 投标企业统一社会信用代码
        /// </summary>
        [XmlElement("bidder_ep_cert_no")]
        public string BidderEpCertNo { get; set; }

        /// <summary>
        /// 投标企业全称
        /// </summary>
        [XmlElement("bidder_ep_name")]
        public string BidderEpName { get; set; }

        /// <summary>
        /// 招标单位统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("bidding_ep_cert_no")]
        public string BiddingEpCertNo { get; set; }

        /// <summary>
        /// 招标单位企业全称
        /// </summary>
        [XmlElement("bidding_ep_name")]
        public string BiddingEpName { get; set; }

        /// <summary>
        /// 合作方客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 招标信息标题标的物，多个用,隔开
        /// </summary>
        [XmlElement("heading_object")]
        public string HeadingObject { get; set; }

        /// <summary>
        /// 报告类型。不传入默认为EP_ZTB_REPORT
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 套餐类别
        /// </summary>
        [XmlElement("pack_type")]
        public string PackType { get; set; }

        /// <summary>
        /// 招标项目所在省市区国标编码，若获取不到，默认给编码值000000
        /// </summary>
        [XmlElement("project_area_code")]
        public string ProjectAreaCode { get; set; }

        /// <summary>
        /// 招标项目所在省市区中文描述，以横线分隔，比如：XX省-XX市-XX区，针对港澳台，仅提供到省级别，如：香港特别行政区
        /// </summary>
        [XmlElement("project_area_desc")]
        public string ProjectAreaDesc { get; set; }

        /// <summary>
        /// 招标信息项目预算，单位元
        /// </summary>
        [XmlElement("project_budget")]
        public string ProjectBudget { get; set; }

        /// <summary>
        /// 招标项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 报告价格。单位人民币元
        /// </summary>
        [XmlElement("report_amount")]
        public string ReportAmount { get; set; }

        /// <summary>
        /// 受理场景码，由蚂蚁企业信用方分发提供，配置有误会返回参数错误
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 招标正文标的物
        /// </summary>
        [XmlElement("text_object")]
        public string TextObject { get; set; }
    }
}
