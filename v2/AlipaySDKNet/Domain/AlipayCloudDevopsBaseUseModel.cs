using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudDevopsBaseUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudDevopsBaseUseModel : AopObject
    {
        /// <summary>
        /// 使用条件
        /// </summary>
        [XmlElement("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 缺陷列表
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 子编码
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 蚂蚁数科
        /// </summary>
        [XmlElement("sub_name")]
        public string SubName { get; set; }
    }
}
