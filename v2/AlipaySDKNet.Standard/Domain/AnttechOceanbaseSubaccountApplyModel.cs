using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseSubaccountApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseSubaccountApplyModel : AopObject
    {
        /// <summary>
        /// 财资子户申请入参模型
        /// </summary>
        [XmlElement("sub_account_apply_request")]
        public SubAccountApplyRequest SubAccountApplyRequest { get; set; }
    }
}
