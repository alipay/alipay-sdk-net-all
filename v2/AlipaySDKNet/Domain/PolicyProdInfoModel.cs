using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyProdInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyProdInfoModel : AopObject
    {
        /// <summary>
        /// 责任剩余保额列表
        /// </summary>
        [XmlArray("duty_residue_amount_list")]
        [XmlArrayItem("duty_residue_amount")]
        public List<DutyResidueAmount> DutyResidueAmountList { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }
    }
}
