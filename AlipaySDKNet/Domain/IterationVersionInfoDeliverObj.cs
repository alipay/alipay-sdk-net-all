using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IterationVersionInfoDeliverObj Data Structure.
    /// </summary>
    [Serializable]
    public class IterationVersionInfoDeliverObj : AopObject
    {
        /// <summary>
        /// 验收用例
        /// </summary>
        [XmlElement("acceptance_use_case")]
        public string AcceptanceUseCase { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [XmlElement("actual_release_time")]
        public string ActualReleaseTime { get; set; }

        /// <summary>
        /// 需求详情
        /// </summary>
        [XmlElement("aone_linke")]
        public string AoneLinke { get; set; }

        /// <summary>
        /// 部署形态
        /// </summary>
        [XmlElement("deploy_type")]
        public string DeployType { get; set; }

        /// <summary>
        /// 开发指南
        /// </summary>
        [XmlElement("development_guide")]
        public string DevelopmentGuide { get; set; }

        /// <summary>
        /// 其他文档
        /// </summary>
        [XmlElement("else_info")]
        public string ElseInfo { get; set; }

        /// <summary>
        /// 停止维护日期
        /// </summary>
        [XmlElement("eom")]
        public string Eom { get; set; }

        /// <summary>
        /// 停止支持日期
        /// </summary>
        [XmlElement("eos")]
        public string Eos { get; set; }

        /// <summary>
        /// 功能测试报告
        /// </summary>
        [XmlElement("functional_test_report")]
        public string FunctionalTestReport { get; set; }

        /// <summary>
        /// 版本信息表的主键id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 重点需求
        /// </summary>
        [XmlElement("key_needs")]
        public string KeyNeeds { get; set; }

        /// <summary>
        /// L2名称
        /// </summary>
        [XmlElement("l_2")]
        public string L2 { get; set; }

        /// <summary>
        /// L3名称
        /// </summary>
        [XmlElement("l_3")]
        public string L3 { get; set; }

        /// <summary>
        /// 商业中台code
        /// </summary>
        [XmlElement("l_3_code")]
        public string L3Code { get; set; }

        /// <summary>
        /// 迭代版本部署的硬件平台信息
        /// </summary>
        [XmlElement("multiplatform")]
        public string Multiplatform { get; set; }

        /// <summary>
        /// 性能测试报告
        /// </summary>
        [XmlElement("performance_test_report")]
        public string PerformanceTestReport { get; set; }

        /// <summary>
        /// 需求规格说明书（或PRD）/产品白皮书
        /// </summary>
        [XmlElement("product_white_paper")]
        public string ProductWhitePaper { get; set; }

        /// <summary>
        /// releaseNote
        /// </summary>
        [XmlElement("release_note")]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// 安全白皮书|报告
        /// </summary>
        [XmlElement("security_white_paper")]
        public string SecurityWhitePaper { get; set; }

        /// <summary>
        /// 版本创建的时间
        /// </summary>
        [XmlElement("stamp_time")]
        public string StampTime { get; set; }

        /// <summary>
        /// 系统设计说明书（系分）/技术白皮书
        /// </summary>
        [XmlElement("sys_design_specification")]
        public string SysDesignSpecification { get; set; }

        /// <summary>
        /// 系统安装部署手册
        /// </summary>
        [XmlElement("sys_installation_and_deployment_manual")]
        public string SysInstallationAndDeploymentManual { get; set; }

        /// <summary>
        /// 系统安装包|镜像
        /// </summary>
        [XmlElement("sys_installation_package")]
        public string SysInstallationPackage { get; set; }

        /// <summary>
        /// 系统运维手册
        /// </summary>
        [XmlElement("sys_operation_and_maintenance_manual")]
        public string SysOperationAndMaintenanceManual { get; set; }

        /// <summary>
        /// 技术白皮书
        /// </summary>
        [XmlElement("tech_white_paper")]
        public string TechWhitePaper { get; set; }

        /// <summary>
        /// 用户手册
        /// </summary>
        [XmlElement("user_manual")]
        public string UserManual { get; set; }

        /// <summary>
        /// 版本下载
        /// </summary>
        [XmlElement("version_download")]
        public string VersionDownload { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_num")]
        public string VersionNum { get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [XmlElement("version_status")]
        public string VersionStatus { get; set; }

        /// <summary>
        /// 版本类型
        /// </summary>
        [XmlElement("version_type")]
        public string VersionType { get; set; }
    }
}
