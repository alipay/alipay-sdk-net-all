using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DesignatedDrivingFeeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DesignatedDrivingFeeDetail : AopObject
    {
        /// <summary>
        /// 费用金额 参考DesignatedDrivingFeeTypeEnum
        /// </summary>
        [XmlElement("fee_amount")]
        public string FeeAmount { get; set; }

        /// <summary>
        /// 费用真实描述，注意和fee title区分开，fee desc是包含具体信息的 参考DesignatedDrivingFeeTypeEnum
        /// </summary>
        [XmlElement("fee_desc")]
        public string FeeDesc { get; set; }

        /// <summary>
        /// 费用类型标识 参考DesignatedDrivingFeeTypeEnum
        /// </summary>
        [XmlElement("fee_id")]
        public string FeeId { get; set; }

        /// <summary>
        /// 代驾费用标题，注意和代驾费用描述区分开，费用描述由isv定义，比如等候费（5分钟） 参考DesignatedDrivingFeeTypeEnum
        /// </summary>
        [XmlElement("fee_title")]
        public string FeeTitle { get; set; }
    }
}
