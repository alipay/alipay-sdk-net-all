using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoCoilBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoCoilBindModel : AopObject
    {
        /// <summary>
        /// 活动创建接口的返回值中包含活动id
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 需要与活动绑定的线圈编号id
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 1. 如小程序或者h5网页 2. 现在只有009可以为空，其他情况不能为空。
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 业务自定义场景配置
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 活动创建接口的返回值中包含活动方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
