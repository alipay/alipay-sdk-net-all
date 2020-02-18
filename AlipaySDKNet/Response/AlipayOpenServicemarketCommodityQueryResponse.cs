using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketCommodityQueryResponse : AopResponse
    {
        /// <summary>
        /// 热点URL
        /// </summary>
        [XmlElement("app_hot_logo")]
        public string AppHotLogo { get; set; }

        /// <summary>
        /// 插件服务审核备注
        /// </summary>
        [XmlElement("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 授权文件url
        /// </summary>
        [XmlElement("authorization_file")]
        public string AuthorizationFile { get; set; }

        /// <summary>
        /// 插件应用类型
        /// </summary>
        [XmlElement("biz_type_code")]
        public string BizTypeCode { get; set; }

        /// <summary>
        /// CARLIFE("车主服务", "001"),  MEDICALCARE("医疗服务", "003"),  CITYSERVICE("城市服务", "004"),  MOBILE_OPERATOR("运营商服务", "005");
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 服务归属  0-自主开发  1-委托开发者
        /// </summary>
        [XmlElement("commodity_affiliation")]
        public string CommodityAffiliation { get; set; }

        /// <summary>
        /// 服务插件id
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务商联系人
        /// </summary>
        [XmlElement("contactor")]
        public string Contactor { get; set; }

        /// <summary>
        /// 服务创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 服务logo地址
        /// </summary>
        [XmlElement("log_url")]
        public string LogUrl { get; set; }

        /// <summary>
        /// 移动端服务配置地址
        /// </summary>
        [XmlElement("mobile_visiturl")]
        public string MobileVisiturl { get; set; }

        /// <summary>
        /// 服务创建者名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务商联系人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// ONLINE-已上架  OFFLINE-待上架  AUDIT-审核中  AUDIT_REJECT-审核拒绝  AUDIT_OFFLINE-已下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 0表示BD不可审核   1表示BD可以审核
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 服务插件相关描述信息
        /// </summary>
        [XmlElement("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// 应用验收说明
        /// </summary>
        [XmlElement("test_detail")]
        public string TestDetail { get; set; }

        /// <summary>
        /// 压力测试报告url
        /// </summary>
        [XmlElement("test_report")]
        public string TestReport { get; set; }

        /// <summary>
        /// 服务插件名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户指南url
        /// </summary>
        [XmlElement("user_guide")]
        public string UserGuide { get; set; }

        /// <summary>
        /// 服务创建者ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
