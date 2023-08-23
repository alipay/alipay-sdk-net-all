using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcvApproverDto Data Structure.
    /// </summary>
    [Serializable]
    public class RcvApproverDto : AopObject
    {
        /// <summary>
        /// 资产管理员
        /// </summary>
        [XmlArray("asset_manager")]
        [XmlArrayItem("string")]
        public List<string> AssetManager { get; set; }

        /// <summary>
        /// 财务初审
        /// </summary>
        [XmlArray("financial_review")]
        [XmlArrayItem("string")]
        public List<string> FinancialReview { get; set; }

        /// <summary>
        /// 财务复审
        /// </summary>
        [XmlArray("financial_super")]
        [XmlArrayItem("string")]
        public List<string> FinancialSuper { get; set; }

        /// <summary>
        /// 实际需求方
        /// </summary>
        [XmlArray("requester")]
        [XmlArrayItem("string")]
        public List<string> Requester { get; set; }

        /// <summary>
        /// 需求方主管
        /// </summary>
        [XmlArray("requester_supervisor")]
        [XmlArrayItem("string")]
        public List<string> RequesterSupervisor { get; set; }

        /// <summary>
        /// 指定新资产管理员
        /// </summary>
        [XmlArray("specify_asset_manager")]
        [XmlArrayItem("string")]
        public List<string> SpecifyAssetManager { get; set; }

        /// <summary>
        /// 指定新实际需求方
        /// </summary>
        [XmlArray("specify_requester")]
        [XmlArrayItem("string")]
        public List<string> SpecifyRequester { get; set; }
    }
}
