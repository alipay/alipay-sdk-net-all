using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractApprovalInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractApprovalInfoVO : AopObject
    {
        /// <summary>
        /// 审批附件url列表
        /// </summary>
        [XmlArray("file_urls")]
        [XmlArrayItem("string")]
        public List<string> FileUrls { get; set; }

        /// <summary>
        /// 审批环节
        /// </summary>
        [XmlElement("node")]
        public string Node { get; set; }

        /// <summary>
        /// 审批时间（格式如：2019-08-08 10:00:00）
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 审批人（姓名&花名）
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 审批结果（待审核、通过、驳回）
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
