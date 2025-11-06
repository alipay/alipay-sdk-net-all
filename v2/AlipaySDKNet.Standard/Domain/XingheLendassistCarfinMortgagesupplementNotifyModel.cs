using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinMortgagesupplementNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinMortgagesupplementNotifyModel : AopObject
    {
        /// <summary>
        /// 金融机构补充协议列表
        /// </summary>
        [XmlArray("agreement_list")]
        [XmlArrayItem("agreement_full_info")]
        public List<AgreementFullInfo> AgreementList { get; set; }

        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 星河侧唯一支用申请单号
        /// </summary>
        [XmlElement("lend_apply_no")]
        public string LendApplyNo { get; set; }

        /// <summary>
        /// 星河侧唯一抵押订单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }

        /// <summary>
        /// 机构侧唯一业务单号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 外部支用申请单号
        /// </summary>
        [XmlElement("out_lend_apply_no")]
        public string OutLendApplyNo { get; set; }

        /// <summary>
        /// 需要补充的文件资料
        /// </summary>
        [XmlArray("supple_file_list")]
        [XmlArrayItem("string")]
        public List<string> SuppleFileList { get; set; }

        /// <summary>
        /// 需要补充的资料列表
        /// </summary>
        [XmlArray("supplement_list")]
        [XmlArrayItem("string")]
        public List<string> SupplementList { get; set; }
    }
}
