using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinFinagreementNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinFinagreementNotifyModel : AopObject
    {
        /// <summary>
        /// 协议列表
        /// </summary>
        [XmlArray("agreement_file_list")]
        [XmlArrayItem("agreement_file")]
        public List<AgreementFile> AgreementFileList { get; set; }

        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 星河侧唯一支用订单号
        /// </summary>
        [XmlElement("lend_apply_no")]
        public string LendApplyNo { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 外部支用单号
        /// </summary>
        [XmlElement("out_lend_apply_no")]
        public string OutLendApplyNo { get; set; }
    }
}
