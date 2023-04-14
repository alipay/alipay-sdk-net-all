using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseInfoDTO : AopObject
    {
        /// <summary>
        /// 账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 因公签约状态 UNACTIVATED:未激活 ACTIVATED:已激活 说明：表示签约资金因公付
        /// </summary>
        [XmlElement("activate")]
        public string Activate { get; set; }

        /// <summary>
        /// 企业认证等级 10初级认证  30 高级认证
        /// </summary>
        [XmlElement("auth_level")]
        public string AuthLevel { get; set; }

        /// <summary>
        /// 认证状态  NO_AUTH：未认证 IN_AUTH：认证中 HAS_AUTH：已认证
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 统一社会信用码
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [XmlElement("enterprise_email")]
        public string EnterpriseEmail { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 封闭场景（如班车）的人脸库id
        /// </summary>
        [XmlElement("iot_group_id")]
        public string IotGroupId { get; set; }

        /// <summary>
        /// 开放场景（如团餐）的人脸库id
        /// </summary>
        [XmlElement("iot_logic_group_id")]
        public string IotLogicGroupId { get; set; }

        /// <summary>
        /// 外部平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 外部平台id
        /// </summary>
        [XmlElement("platform_out_id")]
        public string PlatformOutId { get; set; }

        /// <summary>
        /// 企业服务协议状态 UNSIGNED:未签约 SIGNED:已签约 TERMINATED:已解约 说明：表示签约企业码服务协议
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 企业当前状态 SYNC：数据同步中 NORMAL：正常 WITHDRAW：注销
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
