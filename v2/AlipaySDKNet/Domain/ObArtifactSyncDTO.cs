using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObArtifactSyncDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ObArtifactSyncDTO : AopObject
    {
        /// <summary>
        /// 制品全称
        /// </summary>
        [XmlElement("artifact_fullname")]
        public string ArtifactFullname { get; set; }

        /// <summary>
        /// 制品版本
        /// </summary>
        [XmlElement("artifact_version")]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// 打包的tag或者branch
        /// </summary>
        [XmlElement("branch_or_tag")]
        public string BranchOrTag { get; set; }

        /// <summary>
        /// 制品打包的构建id，某type具体项目下全局唯一。默认值为-1，代表制品暂时未在制品平台打包
        /// </summary>
        [XmlElement("build_id")]
        public long BuildId { get; set; }

        /// <summary>
        /// commit_id
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }

        /// <summary>
        /// 制品生成时间 2022-11-27 19:38:40
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 豁免申请流程
        /// </summary>
        [XmlArray("exempt_approval_process_details")]
        [XmlArrayItem("exempt_approval_process_detail")]
        public List<ExemptApprovalProcessDetail> ExemptApprovalProcessDetails { get; set; }

        /// <summary>
        /// 对外披露流程状态
        /// </summary>
        [XmlElement("external_disclosure_process_state")]
        public string ExternalDisclosureProcessState { get; set; }

        /// <summary>
        /// 对外披露流程链接
        /// </summary>
        [XmlElement("external_disclosure_process_url")]
        public string ExternalDisclosureProcessUrl { get; set; }

        /// <summary>
        /// md5
        /// </summary>
        [XmlElement("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 固定为 "oceanbase"
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 点击发布obg的发布人
        /// </summary>
        [XmlElement("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 制品打包目的
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// 制品打包的源码地址
        /// </summary>
        [XmlElement("repo_url")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// ob制品扫描详情
        /// </summary>
        [XmlArray("scan_details")]
        [XmlArrayItem("scan_detail")]
        public List<ScanDetail> ScanDetails { get; set; }

        /// <summary>
        /// 制品大小
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 制品触发打包人
        /// </summary>
        [XmlElement("trigger")]
        public string Trigger { get; set; }

        /// <summary>
        /// 制品类型 jar,rpm,docker,common.etc
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
